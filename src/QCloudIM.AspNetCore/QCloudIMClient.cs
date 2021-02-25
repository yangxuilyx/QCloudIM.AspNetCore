using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using QCloudIM.AspNetCore.Models;
using QCloudIM.AspNetCore.Options;
using QCloudIM.AspNetCore.Utility;
using RestSharp;
using tencentyun;

namespace QCloudIM.AspNetCore
{
    public abstract class QCloudIMClient
    {
        private const string BaseUrl = "https://console.tim.qq.com";

        protected string Version = "v4";

        private readonly string _appId;
        private readonly string _identifier;

        private readonly string _privateKey;
        private readonly string _publicKey;
        private readonly int _expire;

        private readonly RestClient _restClient;

        private readonly ITlsSignature _tlsSignature;

        protected QCloudIMClient(IOptions<QCloudIMOption> qCloudImOptions, ITlsSignature tlsSignature)
        {
            _tlsSignature = tlsSignature;
            _appId = qCloudImOptions.Value.SdkAppid;
            _privateKey = qCloudImOptions.Value.PrivateKey;
            _publicKey = qCloudImOptions.Value.PublicKey;
            _identifier = qCloudImOptions.Value.Identifier;
            _expire = qCloudImOptions.Value.Expire;

            _restClient = new RestClient(BaseUrl);
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected abstract string ServiceName { get; }

        protected async Task<TResult> RequestAsync<TRequest, TResult>(string serviceName, string command, TRequest request) where TRequest : QCloudIMRequest, new() where TResult : QCloudIMResult, new()
        {
            var restRequest = GetRestRequest(serviceName, command, request);

            var response = await _restClient.ExecuteTaskAsync<TResult>(restRequest);

            var result = JsonConvert.DeserializeObject<TResult>(response.Content);

            // 异常自行处理
            //if (!Response.Success)
            //{
            //    throw new HttpRequestException(Response.ErrorInfo);
            //}

            return result;
        }
        private string GetUserSig()
        {
            string sig = _tlsSignature.GenUserSig(_identifier);
            return sig;
        }

        private string CreateUrl(string serviceName, string command)
        {
            return
                $"{BaseUrl}/{Version}/{serviceName}/{command}?sdkappid={_appId}&identifier={_identifier}&usersig={GetUserSig()}&random={Math.Abs(new Random().Next()).ToString()}&contenttype=json";
        }

        private RestRequest GetRestRequest<TRequest>(string serviceName, string actionName, TRequest request) where TRequest : QCloudIMRequest, new()
        {
            string url = CreateUrl(serviceName, actionName);

            var restRequest = new RestRequest(url, Method.POST);
            restRequest.AddHeader("Content-Type", "application/json"); //设置HTTP头

            string json = JsonConvert.SerializeObject(request, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            restRequest.AddParameter("application/json; charset=utf-8", json, "application/json;charset=UTF-8",
                ParameterType.RequestBody);
            restRequest.RequestFormat = DataFormat.Json;

            return restRequest;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Models.Config;
using QCloudIM.AspNetCore.Options;
using QCloudIM.AspNetCore.Utility;

namespace QCloudIM.AspNetCore.Clients.Config
{
    /// <summary>
    /// 全局禁言管理
    /// </summary>
    public class QCloudIMConfigClient : QCloudIMClient, IQCloudIMConfigClient
    {
        public QCloudIMConfigClient(IOptions<QCloudIMOption> qCloudImOptions, ITlsSignature tlsSignature) : base(qCloudImOptions, tlsSignature)
        {
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "openconfigsvr";

        /// <summary>
        /// 设置全局禁言：setnospeaking
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SetNoSpeakingResult> SetNoSpeakingAsync(SetNoSpeakingRequest request)
        {
            return await RequestAsync<SetNoSpeakingRequest, SetNoSpeakingResult>(ServiceName, "setnospeaking", request);
        }

        /// <summary>
        /// 获取全局禁言：getnospeaking
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetNoSpeakingResult> GetNoSpeakingAsync(GetNoSpeakingRequest request)
        {
            return await RequestAsync<GetNoSpeakingRequest, GetNoSpeakingResult>(ServiceName, "getnospeaking", request);
        }

    
    }
}

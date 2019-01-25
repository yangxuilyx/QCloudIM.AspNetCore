using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Clients.Config;
using QCloudIM.AspNetCore.Clients.Dirtywords;
using QCloudIM.AspNetCore.Clients.Group;
using QCloudIM.AspNetCore.Clients.OLogin;
using QCloudIM.AspNetCore.Clients.OpenIm;
using QCloudIM.AspNetCore.Clients.Profile;
using QCloudIM.AspNetCore.Clients.Sns;
using QCloudIM.AspNetCore.Clients.Svc;
using QCloudIM.AspNetCore.Options;
using RestSharp;

namespace QCloudIM.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加QCloudIM
        /// </summary>
        /// <param name="service"></param>
        public static void AddQCloudIM(this IServiceCollection service)
        {
            AddQCloudIM(service, null);
        }
        /// <summary>
        /// 添加QCloudIM
        /// </summary>
        /// <param name="service"></param>
        /// <param name="options"></param>
        public static void AddQCloudIM(this IServiceCollection service, Action<QCloudIMOption> options)
        {
            service.AddScoped<IQCloudIMGroupClient, QCloudIMGroupClient>();
            service.AddScoped<IQCloudIMConfigClient, QCloudIMConfigClient>();
            service.AddScoped<IQCloudIMDirtywordsClient, QCloudIMDirtywordsClient>();
            service.AddScoped<IQCloudIMOLoginClient, QCloudIMOLoginClient>();
            service.AddScoped<IQCloudIMOpenImClient, QCloudIMOpenImClient>();
            service.AddScoped<IQCloudIMProfileClient, QCloudIMProfileClient>();
            service.AddScoped<IQCloudIMSnsClient, QCloudIMSnsClient>();
            service.AddScoped<IQCloudIMSvcClient, QCloudIMSvcClient>();

            if (options != null)
            {
                service.Configure(options);
            }
        }

    }
}
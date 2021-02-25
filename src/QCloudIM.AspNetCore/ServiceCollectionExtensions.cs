using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
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
using QCloudIM.AspNetCore.Utility;
using RestSharp;
using tencentyun;

namespace QCloudIM.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加QCloudIM
        /// </summary>
        /// <param name="services"></param>
        public static void AddQCloudIM(this IServiceCollection services)
        {
            AddQCloudIM(services, null);
        }
        /// <summary>
        /// 添加QCloudIM
        /// </summary>
        /// <param name="services"></param>
        /// <param name="setupAction"></param>
        public static void AddQCloudIM(this IServiceCollection services, Action<QCloudIMOption> setupAction)
        {
            services.AddScoped<IQCloudIMGroupClient, QCloudIMGroupClient>();
            services.AddScoped<IQCloudIMConfigClient, QCloudIMConfigClient>();
            services.AddScoped<IQCloudIMDirtywordsClient, QCloudIMDirtywordsClient>();
            services.AddScoped<IQCloudIMOLoginClient, QCloudIMOLoginClient>();
            services.AddScoped<IQCloudIMOpenImClient, QCloudIMOpenImClient>();
            services.AddScoped<IQCloudIMProfileClient, QCloudIMProfileClient>();
            services.AddScoped<IQCloudIMSnsClient, QCloudIMSnsClient>();
            services.AddScoped<IQCloudIMSvcClient, QCloudIMSvcClient>();
            services.AddSingleton<ITlsSignature, TLSSigAPIv2>();


            if (setupAction != null)
            {
                QCloudIMOption options = new QCloudIMOption();
                setupAction(options);

                if (options.Version == "v1")
                {
                    services.Replace(ServiceDescriptor.Singleton<ITlsSignature, TlsSignature>());
                }
          
                services.Configure(setupAction);
            }
        }

    }
}
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Groups;
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
        /// <param name="options"></param>
        public static void AddQCloudIM(this IServiceCollection service)
        {
            AddQCloudIM(null);
        }
        /// <summary>
        /// 添加QCloudIM
        /// </summary>
        /// <param name="service"></param>
        /// <param name="options"></param>
        public static void AddQCloudIM(this IServiceCollection service, Action<QCloudIMOption> options)
        {
            service.AddScoped<IQCloudIMGroupClient, QCloudIMGroupClient>();

            if (options != null)
            {
                service.Configure(options);
            }
        }

    }
}
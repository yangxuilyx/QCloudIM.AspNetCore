using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Models.Profile;
using QCloudIM.AspNetCore.Options;

namespace QCloudIM.AspNetCore.Clients.Profile
{
    /// <summary>
    /// 资料管理
    /// </summary>
    public class QCloudIMProfileClient : QCloudIMClient, IQCloudIMProfileClient
    {
        public QCloudIMProfileClient(IOptions<QCloudIMOption> qCloudImOptions) : base(qCloudImOptions)
        {
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "profile";

        /// <summary>
        /// 拉取资料：portrait_get
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PortraitGetResult> PortraitGetAsync(PortraitGetRequest request)
        {
            return await RequestAsync<PortraitGetRequest, PortraitGetResult>(ServiceName, "portrait_get", request);
        }

        /// <summary>
        /// 设置资料：portrait_set
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<PortraitSetResult> PortraitSetAsync(PortraitSetRequest request)
        {
            return await RequestAsync<PortraitSetRequest, PortraitSetResult>(ServiceName, "portrait_set", request);
        }
    }
}
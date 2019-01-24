using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Options;
using QCloudIM.AspNetCore.Models.Groups;

namespace QCloudIM.AspNetCore.Groups
{
    /// <summary>
    /// 群组管理实现
    /// </summary>
    public class QCloudIMGroupClient : QCloudIMClient, IQCloudIMGroupClient
    {
        public QCloudIMGroupClient(IOptions<QCloudIMOption> qCloudImOptions) : base(qCloudImOptions)
        {
        }

        /// <summary>
        /// 获取所有群组:get_appid_group_list
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetGroupListResult> GetGroupList(GetGroupListRequest request)
        {
            return await RequestAsync<GetGroupListRequest, GetGroupListResult>(ServiceName, "get_appid_group_list", request);
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "group_open_http_svc";
    }
}
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
        public async Task<GetGroupListResult> GetGroupListAsync(GetGroupListRequest request)
        {
            return await RequestAsync<GetGroupListRequest, GetGroupListResult>(ServiceName, "get_appid_group_list", request);
        }

        /// <summary>
        /// 创建群组：create_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<CreateGroupResult> CreateGroupAsync(CreateGroupRequest request)
        {
            return await RequestAsync<CreateGroupRequest, CreateGroupResult>(ServiceName, "create_group", request);
        }

        /// <summary>
        /// 获取群组详细资料：get_group_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetGroupInfoResult> GetGroupInfoAsync(GetGroupInfoRequest request)
        {
            return await RequestAsync<GetGroupInfoRequest, GetGroupInfoResult>(ServiceName, "get_group_info", request);
        }

        /// <summary>
        /// 获取群成员详细资料：get_group_member_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetGroupMemberInfoResult> GetGroupMemberInfoAsync(GetGroupMemberInfoRequest request)
        {
            return await RequestAsync<GetGroupMemberInfoRequest, GetGroupMemberInfoResult>(ServiceName, "get_group_member_info", request);
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "group_open_http_svc";
    }
}
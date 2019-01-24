using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.Groups;

namespace QCloudIM.AspNetCore.Groups
{
    /// <summary>
    /// 群组管理接口
    /// </summary>
    public interface IQCloudIMGroupClient
    {
        /// <summary>
        /// 获取所有群组：get_appid_group_list
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetGroupListResult> GetGroupListAsync(GetGroupListRequest request);

        /// <summary>
        /// 创建群组：create_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CreateGroupResult> CreateGroupAsync(CreateGroupRequest request);

        /// <summary>
        /// 获取群组详细资料：get_group_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetGroupInfoResult> GetGroupInfoAsync(GetGroupInfoRequest request);

        /// <summary>
        /// 获取群成员详细资料：get_group_member_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetGroupMemberInfoResult> GetGroupMemberInfoAsync(GetGroupMemberInfoRequest request);
    }
}
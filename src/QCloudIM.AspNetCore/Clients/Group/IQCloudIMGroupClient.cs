using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.Groups;

namespace QCloudIM.AspNetCore.Clients.Group
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

        /// <summary>
        /// 修改群组基础资料：modify_group_base_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ModifyGroupBaseInfoResult> ModifyGroupBaseInfoAsync(ModifyGroupBaseInfoRequest request);

        /// <summary>
        /// 添加群组成员：add_group_member
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AddGroupMemberResult> AddGroupMemberAsync(AddGroupMemberRequest request);

        /// <summary>
        /// 删除群组成员：delete_group_member
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteGroupMemberResult> DeleteGroupMemberAsync(DeleteGroupMemberRequest request);

        /// <summary>
        /// 修改群组成员资料：modify_group_member_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ModifyGroupMemberInfoResult> ModifyGroupMemberInfoAsync(ModifyGroupMemberInfoRequest request);

        /// <summary>
        /// 解散群组：destroy_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DestroyGroupResult> DestroyGroupAsync(DestroyGroupRequest request);

        /// <summary>
        /// 获取用户所加入的群组：get_joined_group_list
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetJoinedGroupListResult> GetJoinedGroupListAsync(GetJoinedGroupListRequest request);

        /// <summary>
        /// 查询用户在群组中的身份：get_role_in_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetRoleInGroupResult> GetRoleInGroupAsync(GetRoleInGroupRequest request);

        /// <summary>
        /// 批量禁言和取消禁言：forbid_send_msg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ForbidSendMsgResult> ForbidSendMsgAsync(ForbidSendMsgRequest request);

        /// <summary>
        /// 获取群组被禁言的列表：get_group_shutted_uin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetGroupShuttedUinResult> GetGroupShuttedUinAsync(GetGroupShuttedUinRequest request);

        /// <summary>
        /// 在群组中发送普通消息：send_group_msg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SendGroupMsgResult> SendGroupMsgAsync(SendGroupMsgRequest request);

        /// <summary>
        /// 在群组中发送系统通知：send_group_system_notification
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SendGroupSystemNotificationResult> SendGroupSystemNotificationAsync(SendGroupSystemNotificationRequest request);

        /// <summary>
        /// 转让群组：change_group_owner
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ChangeGroupOwnerResult> ChangeGroupOwnerAsync(ChangeGroupOwnerRequest request);

        /// <summary>
        /// 导入群资料：import_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ImportGroupResult> ImportGroupAsync(ImportGroupRequest request);

        /// <summary>
        /// 导入群消息：import_group_msg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ImportGroupMsgResult> ImportGroupMsgAsync(ImportGroupMsgRequest request);

        /// <summary>
        /// 导入群成员：import_group_member
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ImportGroupMemberResult> ImportGroupMemberAsync(ImportGroupMemberRequest request);

        /// <summary>
        /// 设置成员未读消息计数：set_unread_msg_num
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SetUnreadMsgNumResult> SetUnreadMsgNumAsync(SetUnreadMsgNumRequest request);

        /// <summary>
        /// 删除指定用户发送的消息：delete_group_msg_by_sender
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteGroupMsgBySenderResult> DeleteGroupMsgBySenderAsync(DeleteGroupMsgBySenderRequest request);

        /// <summary>
        /// 拉取群漫游消息:group_msg_get_simple
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GroupMsgGetSimpleResult> GroupMsgGetSimpleAsync(GroupMsgGetSimpleRequest request);
    }
}
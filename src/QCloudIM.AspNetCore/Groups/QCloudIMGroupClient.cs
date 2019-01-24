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
        /// 修改群组基础资料：modify_group_base_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ModifyGroupBaseInfoResult> ModifyGroupBaseInfoAsync(ModifyGroupBaseInfoRequest request)
        {
            return await RequestAsync<ModifyGroupBaseInfoRequest, ModifyGroupBaseInfoResult>(ServiceName, "modify_group_base_info", request);
        }

        /// <summary>
        /// 添加群组成员：add_group_member
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddGroupMemberResult> AddGroupMemberAsync(AddGroupMemberRequest request)
        {
            return await RequestAsync<AddGroupMemberRequest, AddGroupMemberResult>(ServiceName, "add_group_member", request);
        }

        /// <summary>
        /// 删除群组成员：delete_group_member
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteGroupMemberResult> DeleteGroupMemberAsync(DeleteGroupMemberRequest request)
        {
            return await RequestAsync<DeleteGroupMemberRequest, DeleteGroupMemberResult>(ServiceName, "delete_group_member", request);
        }

        /// <summary>
        /// 修改群组成员资料：modify_group_member_info
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ModifyGroupMemberInfoResult> ModifyGroupMemberInfoAsync(ModifyGroupMemberInfoRequest request)
        {
            return await RequestAsync<ModifyGroupMemberInfoRequest, ModifyGroupMemberInfoResult>(ServiceName, "modify_group_member_info", request);
        }

        /// <summary>
        /// 解散群组：destroy_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DestroyGroupResult> DestroyGroupAsync(DestroyGroupRequest request)
        {
            return await RequestAsync<DestroyGroupRequest, DestroyGroupResult>(ServiceName, "destroy_group", request);
        }

        /// <summary>
        /// 获取用户所加入的群组：get_joined_group_list
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetJoinedGroupListResult> GetJoinedGroupListAsync(GetJoinedGroupListRequest request)
        {
            return await RequestAsync<GetJoinedGroupListRequest, GetJoinedGroupListResult>(ServiceName, "get_joined_group_list", request);
        }

        /// <summary>
        /// 查询用户在群组中的身份：get_role_in_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetRoleInGroupResult> GetRoleInGroupAsync(GetRoleInGroupRequest request)
        {
            return await RequestAsync<GetRoleInGroupRequest, GetRoleInGroupResult>(ServiceName, "get_role_in_group", request);
        }

        /// <summary>
        /// 批量禁言和取消禁言：forbid_send_msg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ForbidSendMsgResult> ForbidSendMsgAsync(ForbidSendMsgRequest request)
        {
            return await RequestAsync<ForbidSendMsgRequest, ForbidSendMsgResult>(ServiceName, "forbid_send_msg", request);
        }

        /// <summary>
        /// 获取群组被禁言的列表：get_group_shutted_uin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetGroupShuttedUinResult> GetGroupShuttedUinAsync(GetGroupShuttedUinRequest request)
        {
            return await RequestAsync<GetGroupShuttedUinRequest, GetGroupShuttedUinResult>(ServiceName, "get_group_shutted_uin", request);
        }

        /// <summary>
        /// 在群组中发送普通消息：send_group_msg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SendGroupMsgResult> SendGroupMsgAsync(SendGroupMsgRequest request)
        {
            return await RequestAsync<SendGroupMsgRequest, SendGroupMsgResult>(ServiceName, "send_group_msg", request);
        }

        /// <summary>
        /// 在群组中发送系统通知：send_group_system_notification
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SendGroupSystemNotificationResult> SendGroupSystemNotificationAsync(SendGroupSystemNotificationRequest request)
        {
            return await RequestAsync<SendGroupSystemNotificationRequest, SendGroupSystemNotificationResult>(ServiceName, "send_group_system_notification", request);
        }

        /// <summary>
        /// 转让群组：change_group_owner
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ChangeGroupOwnerResult> ChangeGroupOwnerAsync(ChangeGroupOwnerRequest request)
        {
            return await RequestAsync<ChangeGroupOwnerRequest, ChangeGroupOwnerResult>(ServiceName, "change_group_owner", request);
        }

        /// <summary>
        /// 导入群资料：import_group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ImportGroupResult> ImportGroupAsync(ImportGroupRequest request)
        {
            return await RequestAsync<ImportGroupRequest, ImportGroupResult>(ServiceName, "import_group", request);
        }

        /// <summary>
        /// 导入群消息：import_group_msg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ImportGroupMsgResult> ImportGroupMsgAsync(ImportGroupMsgRequest request)
        {
            return await RequestAsync<ImportGroupMsgRequest, ImportGroupMsgResult>(ServiceName, "import_group_msg", request);
        }

        /// <summary>
        /// 导入群成员：import_group_member
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ImportGroupMemberResult> ImportGroupMemberAsync(ImportGroupMemberRequest request)
        {
            return await RequestAsync<ImportGroupMemberRequest, ImportGroupMemberResult>(ServiceName, "import_group_member", request);
        }

        /// <summary>
        /// 设置成员未读消息计数：set_unread_msg_num
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SetUnreadMsgNumResult> SetUnreadMsgNumAsync(SetUnreadMsgNumRequest request)
        {
            return await RequestAsync<SetUnreadMsgNumRequest, SetUnreadMsgNumResult>(ServiceName, "set_unread_msg_num", request);
        }

        /// <summary>
        /// 删除指定用户发送的消息：delete_group_msg_by_sender
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteGroupMsgBySenderResult> DeleteGroupMsgBySenderAsync(DeleteGroupMsgBySenderRequest request)
        {
            return await RequestAsync<DeleteGroupMsgBySenderRequest, DeleteGroupMsgBySenderResult>(ServiceName, "delete_group_msg_by_sender", request);
        }

        /// <summary>
        /// 拉取群漫游消息:group_msg_get_simple
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GroupMsgGetSimpleResult> GroupMsgGetSimpleAsync(GroupMsgGetSimpleRequest request)
        {
            return await RequestAsync<GroupMsgGetSimpleRequest, GroupMsgGetSimpleResult>(ServiceName, "group_msg_get_simple", request);
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "group_open_http_svc";
    }
}
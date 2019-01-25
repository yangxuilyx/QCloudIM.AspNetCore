using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Models.Sns;
using QCloudIM.AspNetCore.Options;

namespace QCloudIM.AspNetCore.Clients.Sns
{
    /// <summary>
    /// 关系链管理
    /// </summary>
    public class QCloudIMSnsClient : QCloudIMClient, IQCloudIMSnsClient
    {
        public QCloudIMSnsClient(IOptions<QCloudIMOption> qCloudImOptions) : base(qCloudImOptions)
        {
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "sns";

        /// <summary>
        /// 添加好友：friend_add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FriendAddResult> FriendAddAsync(FriendAddRequest request)
        {
            return await RequestAsync<FriendAddRequest, FriendAddResult>(ServiceName, "friend_add", request);
        }

        /// <summary>
        /// 导入好友：friend_import
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FriendImportResult> FriendImportAsync(FriendImportRequest request)
        {
            return await RequestAsync<FriendImportRequest, FriendImportResult>(ServiceName, "friend_import", request);
        }

        /// <summary>
        /// 删除好友：friend_delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FriendDeleteResult> FriendDeleteAsync(FriendDeleteRequest request)
        {
            return await RequestAsync<FriendDeleteRequest, FriendDeleteResult>(ServiceName, "friend_delete", request);
        }

        /// <summary>
        /// 删除所有好友：friend_delete_all
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FriendDeleteAllResult> FriendDeleteAllAsync(FriendDeleteAllRequest request)
        {
            return await RequestAsync<FriendDeleteAllRequest, FriendDeleteAllResult>(ServiceName, "friend_delete_all", request);
        }

        /// <summary>
        /// 校验好友：friend_check
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FriendCheckResult> FriendCheckAsync(FriendCheckRequest request)
        {
            return await RequestAsync<FriendCheckRequest, FriendCheckResult>(ServiceName, "friend_check", request);
        }

        /// <summary>
        /// 拉取好友：friend_get_all
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FriendGetAllResult> FriendGetAllAsync(FriendGetAllRequest request)
        {
            return await RequestAsync<FriendGetAllRequest, FriendGetAllResult>(ServiceName, "friend_get_all", request);
        }

        /// <summary>
        /// 拉取指定好友：friend_get_list
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FriendGetListResult> FriendGetListAsync(FriendGetListRequest request)
        {
            return await RequestAsync<FriendGetListRequest, FriendGetListResult>(ServiceName, "friend_get_list", request);
        }

        /// <summary>
        /// 添加黑名单：black_list_add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BlackListAddResult> BlackListAddAsync(BlackListAddRequest request)
        {
            return await RequestAsync<BlackListAddRequest, BlackListAddResult>(ServiceName, "black_list_add", request);
        }

        /// <summary>
        /// 删除黑名单：black_list_delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BlackListDeleteResult> BlackListDeleteAsync(BlackListDeleteRequest request)
        {
            return await RequestAsync<BlackListDeleteRequest, BlackListDeleteResult>(ServiceName, "black_list_delete", request);
        }

        /// <summary>
        /// 拉取黑名单：black_list_get
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BlackListGetResult> BlackListGetAsync(BlackListGetRequest request)
        {
            return await RequestAsync<BlackListGetRequest, BlackListGetResult>(ServiceName, "black_list_get", request);
        }

        /// <summary>
        /// 校验黑名单：black_list_check
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BlackListCheckResult> BlackListCheckAsync(BlackListCheckRequest request)
        {
            return await RequestAsync<BlackListCheckRequest, BlackListCheckResult>(ServiceName, "black_list_check", request);
        }

        /// <summary>
        /// 添加分组：group_add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GroupAddResult> GroupAddAsync(GroupAddRequest request)
        {
            return await RequestAsync<GroupAddRequest, GroupAddResult>(ServiceName, "group_add", request);
        }

        /// <summary>
        /// 删除分组：group_delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GroupDeleteResult> GroupDeleteAsync(GroupDeleteRequest request)
        {
            return await RequestAsync<GroupDeleteRequest, GroupDeleteResult>(ServiceName, "group_delete", request);
        }
    }
}
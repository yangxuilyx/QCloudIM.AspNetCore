using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.Sns;

namespace QCloudIM.AspNetCore.Clients.Sns
{
    /// <summary>
    /// 关系链管理
    /// </summary>
    public interface IQCloudIMSnsClient
    {
        /// <summary>
        /// 添加好友：friend_add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FriendAddResult> FriendAddAsync(FriendAddRequest request);

        /// <summary>
        /// 导入好友：friend_import
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FriendImportResult> FriendImportAsync(FriendImportRequest request);

        /// <summary>
        /// 删除好友：friend_delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FriendDeleteResult> FriendDeleteAsync(FriendDeleteRequest request);

        /// <summary>
        /// 删除所有好友：friend_delete_all
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FriendDeleteAllResult> FriendDeleteAllAsync(FriendDeleteAllRequest request);

        /// <summary>
        /// 校验好友：friend_check
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FriendCheckResult> FriendCheckAsync(FriendCheckRequest request);

        /// <summary>
        /// 拉取好友：friend_get_all
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FriendGetAllResult> FriendGetAllAsync(FriendGetAllRequest request);

        /// <summary>
        /// 拉取指定好友：friend_get_list
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<FriendGetListResult> FriendGetListAsync(FriendGetListRequest request);

        /// <summary>
        /// 添加黑名单：black_list_add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BlackListAddResult> BlackListAddAsync(BlackListAddRequest request);

        /// <summary>
        /// 删除黑名单：black_list_delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BlackListDeleteResult> BlackListDeleteAsync(BlackListDeleteRequest request);

        /// <summary>
        /// 拉取黑名单：black_list_get
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BlackListGetResult> BlackListGetAsync(BlackListGetRequest request);

        /// <summary>
        /// 校验黑名单：black_list_check
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BlackListCheckResult> BlackListCheckAsync(BlackListCheckRequest request);

        /// <summary>
        /// 添加分组：group_add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GroupAddResult> GroupAddAsync(GroupAddRequest request);

        /// <summary>
        /// 删除分组：group_delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GroupDeleteResult> GroupDeleteAsync(GroupDeleteRequest request);
    }
}
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
        /// 获取所有群组:get_appid_group_list
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetGroupListResult> GetGroupList(GetGroupListRequest request);


    }
}
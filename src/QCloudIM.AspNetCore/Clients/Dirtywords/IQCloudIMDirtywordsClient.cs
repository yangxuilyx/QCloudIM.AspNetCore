using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.Dirtywords;

namespace QCloudIM.AspNetCore.Clients.Dirtywords
{
    /// <summary>
    /// 脏字管理
    /// </summary>
    public interface IQCloudIMDirtywordsClient
    {
        /// <summary>
        /// 查询脏字：get
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetDirtyWordResult> GetDirtyWordAsync(GetDirtyWordRequest request);

        /// <summary>
        /// 添加脏字：add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AddDirtyWordResult> AddDirtyWordAsync(AddDirtyWordRequest request);

        /// <summary>
        /// 删除脏字：delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<DeleteDirtyWordResult> DeleteDirtyWordAsync(DeleteDirtyWordRequest request);
    }
}

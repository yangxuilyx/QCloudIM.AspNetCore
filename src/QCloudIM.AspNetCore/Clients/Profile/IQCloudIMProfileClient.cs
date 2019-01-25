using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.Profile;

namespace QCloudIM.AspNetCore.Clients.Profile
{
    /// <summary>
    /// 资料管理
    /// </summary>
    public interface IQCloudIMProfileClient
    {
        /// <summary>
        /// 拉取资料：portrait_get
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<PortraitGetResult> PortraitGetAsync(PortraitGetRequest request);

        /// <summary>
        /// 设置资料：portrait_set
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<PortraitSetResult> PortraitSetAsync(PortraitSetRequest request);
    }
}

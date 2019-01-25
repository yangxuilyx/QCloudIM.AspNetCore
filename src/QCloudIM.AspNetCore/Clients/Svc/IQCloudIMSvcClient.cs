using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.Svc;

namespace QCloudIM.AspNetCore.Clients.Svc
{
    /// <summary>
    /// 数据下载
    /// </summary>
    public interface IQCloudIMSvcClient
    {
        /// <summary>
        /// 消息记录下载：get_history
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetHistoryResult> GetHistoryAsync(GetHistoryRequest request);
    }
}

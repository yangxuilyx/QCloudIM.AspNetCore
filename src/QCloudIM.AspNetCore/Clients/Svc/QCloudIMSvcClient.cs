using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Models.Svc;
using QCloudIM.AspNetCore.Options;

namespace QCloudIM.AspNetCore.Clients.Svc
{
    /// <summary>
    /// 数据下载
    /// </summary>
    public class QCloudIMSvcClient : QCloudIMClient, IQCloudIMSvcClient
    {
        public QCloudIMSvcClient(IOptions<QCloudIMOption> qCloudImOptions) : base(qCloudImOptions)
        {
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "open_msg_svc";

        /// <summary>
        /// 消息记录下载：get_history
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetHistoryResult> GetHistoryAsync(GetHistoryRequest request)
        {
            return await RequestAsync<GetHistoryRequest, GetHistoryResult>(ServiceName, "get_history", request);
        }
    }
}
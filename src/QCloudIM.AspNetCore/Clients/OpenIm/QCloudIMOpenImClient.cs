using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Models.OpenIm;
using QCloudIM.AspNetCore.Options;

namespace QCloudIM.AspNetCore.Clients.OpenIm
{
    /// <summary>
    /// 单聊消息
    /// </summary>
    public class QCloudIMOpenImClient : QCloudIMClient, IQCloudIMOpenImClient
    {
        public QCloudIMOpenImClient(IOptions<QCloudIMOption> qCloudImOptions) : base(qCloudImOptions)
        {
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "openim";

        #region 单聊消息

        /// <summary>
        /// 单发单聊消息：sendmsg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<SendMsgResult> SendMsgAsync(SendMsgRequest request)
        {
            return await RequestAsync<SendMsgRequest, SendMsgResult>(ServiceName, "sendmsg", request);
        }

        /// <summary>
        /// 批量发单聊消息：batchsendmsg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BatchSendMsgResult> BatchSendMsgAsync(BatchSendMsgRequest request)
        {
            return await RequestAsync<BatchSendMsgRequest, BatchSendMsgResult>(ServiceName, "batchsendmsg", request);
        }

        /// <summary>
        /// 导入单聊消息：importmsg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ImportMsgResult> ImportMsgAsync(ImportMsgRequest request)
        {
            return await RequestAsync<ImportMsgRequest, ImportMsgResult>(ServiceName, "importmsg", request);
        }

        #endregion

        #region 在线状态

        /// <summary>
        /// 获取用户在线状态：querystate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<QueryStateResult> QueryStateAsync(QueryStateRequest request)
        {
            return await RequestAsync<QueryStateRequest, QueryStateResult>(ServiceName, "querystate", request);
        }

        #endregion
    }
}
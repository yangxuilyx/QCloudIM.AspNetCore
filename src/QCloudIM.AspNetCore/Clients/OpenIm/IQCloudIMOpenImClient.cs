using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.OpenIm;

namespace QCloudIM.AspNetCore.Clients.OpenIm
{
    /// <summary>
    /// 单聊消息
    /// </summary>
    public interface IQCloudIMOpenImClient
    {

        #region 单聊消息

        /// <summary>
        /// 单发单聊消息：sendmsg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SendMsgResult> SendMsgAsync(SendMsgRequest request);

        /// <summary>
        /// 批量发单聊消息：batchsendmsg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BatchSendMsgResult> BatchSendMsgAsync(BatchSendMsgRequest request);

        /// <summary>
        /// 导入单聊消息：importmsg
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ImportMsgResult> ImportMsgAsync(ImportMsgRequest request);

        #endregion

        #region 消息推送



        #endregion

        #region 在线状态

        /// <summary>
        /// 获取用户在线状态：querystate
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<QueryStateResult> QueryStateAsync(QueryStateRequest request);

        #endregion

    }
}

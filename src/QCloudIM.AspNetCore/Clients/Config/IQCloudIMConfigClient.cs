using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.Config;

namespace QCloudIM.AspNetCore.Clients.Config
{
    /// <summary>
    /// 全局禁言管理
    /// </summary>
    public interface IQCloudIMConfigClient
    {
        /// <summary>
        /// 设置全局禁言：setnospeaking
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<SetNoSpeakingResult> SetNoSpeakingAsync(SetNoSpeakingRequest request);

        /// <summary>
        /// 获取全局禁言：getnospeaking
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetNoSpeakingResult> GetNoSpeakingAsync(GetNoSpeakingRequest request);
    }
}

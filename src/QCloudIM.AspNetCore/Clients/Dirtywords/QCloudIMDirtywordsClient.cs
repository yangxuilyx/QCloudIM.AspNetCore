using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Models.Dirtywords;
using QCloudIM.AspNetCore.Options;

namespace QCloudIM.AspNetCore.Clients.Dirtywords
{
    public class QCloudIMDirtywordsClient : QCloudIMClient, IQCloudIMDirtywordsClient
    {
        public QCloudIMDirtywordsClient(IOptions<QCloudIMOption> qCloudImOptions) : base(qCloudImOptions)
        {
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "openim_dirty_words";

        /// <summary>
        /// 查询脏字：get
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetDirtyWordResult> GetDirtyWordAsync(GetDirtyWordRequest request)
        {
            return await RequestAsync<GetDirtyWordRequest, GetDirtyWordResult>(ServiceName, "get", request);
        }

        /// <summary>
        /// 添加脏字：add
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AddDirtyWordResult> AddDirtyWordAsync(AddDirtyWordRequest request)
        {
            return await RequestAsync<AddDirtyWordRequest, AddDirtyWordResult>(ServiceName, "add", request);
        }

        /// <summary>
        /// 删除脏字：delete
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<DeleteDirtyWordResult> DeleteDirtyWordAsync(DeleteDirtyWordRequest request)
        {
            return await RequestAsync<DeleteDirtyWordRequest, DeleteDirtyWordResult>(ServiceName, "delete", request);
        }
    }
}
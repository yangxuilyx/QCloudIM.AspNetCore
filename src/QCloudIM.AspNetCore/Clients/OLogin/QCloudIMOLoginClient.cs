using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using QCloudIM.AspNetCore.Models.OLogin;
using QCloudIM.AspNetCore.Options;

namespace QCloudIM.AspNetCore.Clients.OLogin
{
    /// <summary>
    /// 账号管理
    /// </summary>
    public class QCloudIMOLoginClient : QCloudIMClient, IQCloudIMOLoginClient
    {
        public QCloudIMOLoginClient(IOptions<QCloudIMOption> qCloudImOptions) : base(qCloudImOptions)
        {
        }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <returns></returns>
        protected override string ServiceName => "im_open_login_svc";

        /// <summary>
        /// 独立模式账号导入：account_import
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<AccountImportResult> AccountImportAsync(AccountImportRequest request)
        {
            return await RequestAsync<AccountImportRequest, AccountImportResult>(ServiceName, "account_import", request);
        }

        /// <summary>
        /// 独立模式账号批量导入：multiaccount_import
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<MultiAccountImportResult> MultiAccountImportAsync(MultiAccountImportRequest request)
        {
            return await RequestAsync<MultiAccountImportRequest, MultiAccountImportResult>(ServiceName, "multiaccount_import", request);
        }

        /// <summary>
        /// 托管模式账号导入：register_account_v1
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RegisterAccountResult> RegisterAccountAsync(RegisterAccountRequest request)
        {
            return await RequestAsync<RegisterAccountRequest, RegisterAccountResult>(ServiceName, "register_account_v1", request);
        }

        /// <summary>
        /// 失效账号登录态：kick
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<KickResult> KickAsync(KickRequest request)
        {
            return await RequestAsync<KickRequest, KickResult>(ServiceName, "kick", request);
        }
    }
}
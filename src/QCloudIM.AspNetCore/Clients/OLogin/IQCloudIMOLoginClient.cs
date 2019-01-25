using System.Threading.Tasks;
using QCloudIM.AspNetCore.Models.OLogin;

namespace QCloudIM.AspNetCore.Clients.OLogin
{
    /// <summary>
    /// 账号管理
    /// </summary>
    public interface IQCloudIMOLoginClient
    {
        /// <summary>
        /// 独立模式账号导入：account_import
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AccountImportResult> AccountImportAsync(AccountImportRequest request);

        /// <summary>
        /// 独立模式账号批量导入：multiaccount_import
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MultiAccountImportResult> MultiAccountImportAsync(MultiAccountImportRequest request);

        /// <summary>
        /// 托管模式账号导入：register_account_v1
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<RegisterAccountResult> RegisterAccountAsync(RegisterAccountRequest request);

        /// <summary>
        /// 失效账号登录态：kick
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<KickResult> KickAsync(KickRequest request);
    }
}
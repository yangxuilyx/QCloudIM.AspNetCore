namespace QCloudIM.AspNetCore.Utility
{
    /// <summary>
    /// 签名接口
    /// </summary>
    public interface ITlsSignature
    {
        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        string GenUserSig(string userid, int expire = 180 * 86400);
    }
}
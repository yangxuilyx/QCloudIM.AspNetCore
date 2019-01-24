using ICSharpCode.SharpZipLib.Zip.Compression;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Linq;
using System.Text;

namespace QCloudIM.AspNetCore.Utility
{
    public class TlsSignature
    {
        /// <summary>
        /// 获取用户sign
        /// </summary>
        /// <param name="appid">appid</param>
        /// <param name="privateKey">私钥</param>
        /// <param name="userid">用户名</param>
        /// <param name="expire">userSig有效期，出于安全考虑建议为300秒，您可以根据您的业务场景设置其他值。</param>
        /// <returns>生成的userSig</returns>
        public static string GenUserSig(string appid, string privateKey, string userid, int expire)
        {
            var time = DateTime.Now.Ticks / 1000;
            String serialString =
                "TLS.appid_at_3rd:" + 0 + "\n" +
                "TLS.account_type:" + 0 + "\n" +
                "TLS.identifier:" + userid + "\n" +
                "TLS.sdk_appid:" + appid + "\n" +
                "TLS.time:" + time + "\n" +
                "TLS.expire_after:" + expire + "\n";

            var sign = Convert.ToBase64String(Sign(privateKey, Encoding.UTF8.GetBytes(serialString)));

            String jsonString = "{"
                                + "\"TLS.account_type\":\"" + 0 + "\","
                                + "\"TLS.identifier\":\"" + userid + "\","
                                + "\"TLS.appid_at_3rd\":\"" + 0 + "\","
                                + "\"TLS.sdk_appid\":\"" + appid + "\","
                                + "\"TLS.expire_after\":\"" + expire + "\","
                                + "\"TLS.sig\":\"" + sign + "\","
                                + "\"TLS.time\":\"" + time + "\","
                                + "\"TLS.version\": \"201512300000\""
                                + "}";

            var compressBytes = Compress(Encoding.UTF8.GetBytes(jsonString));

            var userSign = Base64UrlEncode(compressBytes);
            return userSign;
        }

        private static byte[] Compress(byte[] data)
        {
            Deflater mDeflater = new Deflater();
            mDeflater.SetInput(data);
            mDeflater.Finish();
            byte[] compressBytes = new byte[512];
            int compressBytesLength = mDeflater.Deflate(compressBytes);

            mDeflater.Flush();

            return compressBytes.Take(compressBytesLength).ToArray();
        }

        /// <summary>
        /// ECDSA-SHA256签名
        /// </summary>
        /// <param name="privateKey">私钥</param>
        /// <param name="data">需要签名的数据</param>
        /// <returns></returns>
        private static byte[] Sign(string privateKey, byte[] data)
        {
            ECPrivateKeyParameters privateKeyParam = (ECPrivateKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey));

            var signer = SignerUtilities.GetSigner("SHA256withECDSA");
            signer.Init(true, privateKeyParam);
            signer.BlockUpdate(data, 0, data.Length);

            return signer.GenerateSignature();
        }

        /// <summary>
        /// 验证ECDSA-SHA256签名
        /// </summary>
        /// <param name="publicKey">公钥</param>
        /// <param name="data">需要验证的数据原文</param>
        /// <param name="sig">需要验证的签名</param>
        /// <returns>true:验证成功 false:验证失败</returns>
        public static bool Verify(string publicKey, byte[] data, byte[] sig)
        {
            ECPublicKeyParameters publicKeyParam = (ECPublicKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));

            var signer = SignerUtilities.GetSigner("SHA256withECDSA");
            signer.Init(false, publicKeyParam);
            signer.BlockUpdate(data, 0, data.Length);

            return signer.VerifySignature(sig);

        }

        private static string Base64UrlEncode(byte[] data)
        {
            return Convert.ToBase64String(data).Replace('+', '*').Replace('/', '-')
                 .Replace('=', '_');
        }

        private static string Base64UrlDecode(byte[] data)
        {
            return Convert.ToBase64String(data).Replace('*', '+').Replace('-', '/')
                .Replace('_', '=');
        }
    }
}

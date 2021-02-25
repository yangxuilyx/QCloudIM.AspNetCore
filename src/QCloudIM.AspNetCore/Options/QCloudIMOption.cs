﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QCloudIM.AspNetCore.Options
{
    public class QCloudIMOption
    {
        /// <summary>
        /// appid
        /// </summary>
        public string SdkAppid { get; set; }

        /// <summary>
        /// 管理员名称
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// 私钥，v2版本Key
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// 公钥，腾讯云IM后台下载
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// 签名过期时间，单位秒
        /// </summary>
        public int Expire { get; set; }

        public string Version { get; set; } = "v2";
    }
}

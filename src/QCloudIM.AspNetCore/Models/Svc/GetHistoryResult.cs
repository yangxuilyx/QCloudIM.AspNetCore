

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Svc
{

    public class GetHistoryResult : QCloudIMResult
    {

       
        [JsonProperty("File")]
        public virtual IList<FileItem> Files { get; set; }
    }

    public class FileItem
    {

        [JsonProperty("URL")]
        public virtual string Url { get; set; }

        [JsonProperty("ExpireTime")]
        public virtual string ExpireTime { get; set; }

        [JsonProperty("FileSize")]
        public virtual long FileSize { get; set; }

        [JsonProperty("FileMD5")]
        public virtual string FileMd5 { get; set; }

        [JsonProperty("GzipSize")]
        public virtual long GzipSize { get; set; }

        [JsonProperty("GzipMD5")]
        public virtual string GzipMd5 { get; set; }
    }


}
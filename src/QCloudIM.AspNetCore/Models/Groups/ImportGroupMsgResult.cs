

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{

    public class ImportGroupMsgResult : QCloudIMResult
    {
        [JsonProperty("ImportMsgResult")]
        public IList<ImportResultItem> ImportMsgResult { get; set; }
    }
    public class ImportResultItem
    {
        [JsonProperty("Result")]
        public int Result { get; set; }

        [JsonProperty("MsgSeq")]
        public long MsgSeq { get; set; }

        [JsonProperty("MsgTime")]
        public long MsgTime { get; set; }
    }
}
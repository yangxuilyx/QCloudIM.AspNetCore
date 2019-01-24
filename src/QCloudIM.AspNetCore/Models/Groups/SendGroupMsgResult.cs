

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{

    public class SendGroupMsgResult : QCloudIMResult
    {
        [JsonProperty("MsgTime")]
        public long MsgTime { get; set; }

        [JsonProperty("MsgSeq")]

        public int MsgSeq { get; set; }
    }

}


using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Message;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{


    public class GroupMsgGetSimpleResult : QCloudIMResult
    {
 
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("IsFinished")]
        public int IsFinished { get; set; }

        [JsonProperty("RspMsgList")]
        public IList<RspMsgItem> RspMsgList { get; set; }
    }
    public class RspMsgItem
    {
        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("IsPlaceMsg")]
        public int IsPlaceMsg { get; set; }

        [JsonProperty("MsgBody")]
        public IList<MsgBodyItem> MsgBody { get; set; }

        [JsonProperty("MsgRandom")]
        public int MsgRandom { get; set; }

        [JsonProperty("MsgSeq")]
        public long MsgSeq { get; set; }

        [JsonProperty("MsgTimestamp")]
        public long MsgTimestamp { get; set; }
    }
}
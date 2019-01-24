

using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Message;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{

    public class ImportGroupMsgRequest : QCloudIMRequest
    {

        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("MsgList")]
        public IList<MsgListItem> MsgList { get; set; }
    }
    public class MsgListItem
    {
         
        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("SendTime")]
        public long SendTime { get; set; }

        [JsonProperty("Random")]
        public int Random { get; set; }

        [JsonProperty("MsgBody")]
        public IList<MsgBodyItem> MsgBody { get; set; }
    }

}
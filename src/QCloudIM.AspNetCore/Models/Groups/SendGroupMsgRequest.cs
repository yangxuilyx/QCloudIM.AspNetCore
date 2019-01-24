

using QCloudIM.AspNetCore.Models.Message;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{

    public class SendGroupMsgRequest : QCloudIMRequest
    {
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("MsgPriority")]
        public string MsgPriority { get; set; }

        [JsonProperty("Random")]
        public int MsgRandom { get; set; }

        [JsonProperty("OnlineOnlyFlag")]
        public int OnlineOnlyFlag { get; set; }

        [JsonProperty("MsgBody")]
        public IList<MsgBodyItem> MsgBody { get; set; }

        [JsonProperty("OfflinePushInfo")]
        public OfflinePushInfo OfflinePushInfo { get; set; }

        [JsonProperty("ForbidCallbackControl")]
        public IList<string> ForbidCallbackControl { get; set; }
    }

}
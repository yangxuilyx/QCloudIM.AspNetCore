

using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Message;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.OpenIm
{


    public class SendMsgRequest : QCloudIMRequest
    {

        [JsonProperty("SyncOtherMachine")]
        public  int SyncOtherMachine { get; set; }

        [JsonProperty("From_Account")]
        public  string FromAccount { get; set; }

        [JsonProperty("To_Account")]
        public  string ToAccount { get; set; }

        [JsonProperty("MsgLifeTime")]
        public  int MsgLifeTime { get; set; }

        [JsonProperty("MsgRandom")]
        public  int MsgRandom { get; set; }

        [JsonProperty("MsgTimeStamp")]
        public  long MsgTimestamp { get; set; }

        [JsonProperty("MsgBody")]
        public  IList<MsgBodyItem> MsgBody { get; set; }

        [JsonProperty("OfflinePushInfo")]
        public  OfflinePushInfo OfflinePushInfo { get; set; }
    }

}
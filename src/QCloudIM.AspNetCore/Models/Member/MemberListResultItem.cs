 
using Newtonsoft.Json;
 

namespace QCloudIM.AspNetCore.Models.Member
{

    public class MemberListResultItem : MemberListItem
    {


        [JsonProperty("Member_Account")]
        public string MemberAccount { get; set; }

        [JsonProperty("JoinTime")]
        public long JoinTime { get; set; }

        [JsonProperty("MsgSeq")]
        public long MsgSeq { get; set; }

        [JsonProperty("MsgFlag")]
        public string MsgFlag { get; set; }

        [JsonProperty("LastSendMsgTime")]
        public long LastSendMsgTime { get; set; }

        [JsonProperty("ShutUpUntil")]
        public long ShutUpUntil { get; set; }
    }

}
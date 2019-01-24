

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{

    public class ImportGroupMemberRequest : QCloudIMRequest
    {

        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("MemberList")]
        public IList<MemberItem> MemberList { get; set; }
    }
    public class MemberItem
    {
        [JsonProperty("MemberAccount")]
        public string MemberAccount { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        [JsonProperty("JoinTime")]
        public long JoinTime { get; set; }

        [JsonProperty("UnreadMsgNum")]
        public int UnreadMsgNum { get; set; }
    }
}
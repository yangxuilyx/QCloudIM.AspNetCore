

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{

    public class ImportGroupMemberResult : QCloudIMResult
    {
        [JsonProperty("MemberList")]
        public IList<MemberListItem> MemberList { get; set; }
    }

    public class MemberListItem
    {

        [JsonProperty("Member_Account")]
        public string MemberAccount { get; set; }

        [JsonProperty("Result")]
        public int Result { get; set; }
    }

}
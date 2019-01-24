
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{


    public class SearchGroupResult : QCloudIMResult
    {


        [JsonProperty("GroupInfo")]
        public IList<SearchGroupInfo> GroupInfo { get; set; }

        [JsonProperty("TotalRecord")]
        public int TotalRecord { get; set; }
    }
    public class SearchGroupInfo
    { 
        [JsonProperty("ApplyJoinOption")]
        public string ApplyJoinOption { get; set; }

        [JsonProperty("CreateTime")]
        public long CreateTime { get; set; }
        [JsonProperty("ErrorCode")]

        public int ErrorCode { get; set; }
        [JsonProperty("FaceUrl")]

        public string FaceUrl { get; set; }
        [JsonProperty("GroupId")]

        public string GroupId { get; set; }
        [JsonProperty("Introduction")]

        public string Introduction { get; set; }
        [JsonProperty("MaxMemberNum")]

        public int MaxMemberNum { get; set; }

        [JsonProperty("MemberNum")]
        public int MemberNum { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("OnlineMemberNum")]
        public int OnlineMemberNum { get; set; }

        [JsonProperty("Owner_Account")]
        public string OwnerAccount { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }

}
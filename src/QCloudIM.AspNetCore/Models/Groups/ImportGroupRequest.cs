

using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Member;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{


    public class ImportGroupRequest : QCloudIMRequest
    {
        [JsonProperty("Owner_Account")]
        public string OwnerAccount { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Introduction")]
        public string Introduction { get; set; }

        [JsonProperty("Notification")]
        public string Notification { get; set; }

        [JsonProperty("FaceUrl")]
        public string FaceUrl { get; set; }

        [JsonProperty("MaxMemberCount")]
        public int MaxMemberCount { get; set; }

        [JsonProperty("ApplyJoinOption")]
        public string ApplyJoinOption { get; set; }

        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("CreateTime")]
        public long CreateTime { get; set; }

        [JsonProperty("AppDefinedData")]
        public IList<AppDefinedData> AppDefinedData { get; set; }
    }

}
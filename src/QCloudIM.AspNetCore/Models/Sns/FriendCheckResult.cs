

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{

    public class FriendCheckResult : QCloudIMResult
    {

        [JsonProperty("CheckItem")]
        public IList<CheckItem> CheckItem { get; }

        [JsonProperty("Fail_Account")]
        public IList<string> FailAccount { get; set; }

        [JsonProperty("Invalid_Account")]
        public IList<string> InvalidAccount { get; set; }
    }

    public class CheckItem
    {
        [JsonProperty("To_Account")]
        public string ToAccount { get; set; }

        [JsonProperty("Relation")]
        public string Relation { get; set; }

        [JsonProperty("ResultCode")]
        public int ResultCode { get; set; }

        [JsonProperty("ResultInfo")]
        public string ResultInfo { get; set; }
    }

}
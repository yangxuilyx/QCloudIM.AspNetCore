using QCloudIM.AspNetCore.Models.Friend;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{

    public class FriendAddResult : QCloudIMResult
    {

        [JsonProperty("ResultItem")]
        public IList<ResultItem> ResultItem { get; set; }

        [JsonProperty("Fail_Account")]
        public IList<string> FailAccount { get; set; }

        [JsonProperty("Invalid_Account")]
        public IList<string> InvalidAccount { get; set; }
    }

}
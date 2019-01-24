

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Friend
{

    public class ResultItem
    {


        [JsonProperty("To_Account")]
        public string ToAccount { get; set; }

        [JsonProperty("ResultCode")]
        public int ResultCode { get; set; }

        [JsonProperty("ResultInfo")]
        public string ResultInfo { get; set; }
    }

}
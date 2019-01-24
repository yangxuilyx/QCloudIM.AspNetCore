

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Message
{


    public class ErrorListItem
    {

        [JsonProperty("To_Account")]
        public   string ToAccount { get; set; }

        [JsonProperty("ErrorCode")]
        public   int ErrorCode { get; set; }
    }

}
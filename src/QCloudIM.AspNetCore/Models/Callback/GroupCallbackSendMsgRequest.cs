using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Callback
{
   public class GroupCallbackSendMsgRequest
    {
        [JsonProperty("CallbackCommand")]
        public string CallbackCommand { get; set; }
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }
        [JsonProperty("Type")]
        public string Type { get; set; }
        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }
        [JsonProperty("Operator_Account")]
        public string OperatorAccount { get; set; }
        [JsonProperty("Random")]
        public long Random { get; set; }
    }
}

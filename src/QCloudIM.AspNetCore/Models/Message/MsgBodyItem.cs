 
using QCloudIM.AspNetCore.Models.Message.Contents;
using Newtonsoft.Json;
 

namespace QCloudIM.AspNetCore.Models.Message
{
    public class MsgBodyItem
    {
        [JsonProperty("MsgType")]
        public   string MsgType { get; set; }

        [JsonProperty("MsgContent")]
        public   MsgContent MsgContent { get; set; }
    }

}


using Newtonsoft.Json;
 

namespace QCloudIM.AspNetCore.Models.OpenIm
{

    public class SendMsgResult : QCloudIMResult
    {
         
        [JsonProperty("MsgTime")]
        public  long MsgTime { get; set; }
    }


}
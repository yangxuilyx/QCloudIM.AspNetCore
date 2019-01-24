 

using Newtonsoft.Json;
 

namespace QCloudIM.AspNetCore.Models.Message.Contents
{
	 
	public class FaceMsgContent : MsgContent
	{
         
	    [JsonProperty("Index")]
	    public   int Index { get; set; }

        [JsonProperty("Data")]
        public   string Data { get; set; }
	}

}
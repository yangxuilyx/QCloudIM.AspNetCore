 
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Message.Contents
{
	 
	public class TextMsgContent : MsgContent
	{
 
            [JsonProperty("Text")]
	    public   string Text { get; set; }
	}

}
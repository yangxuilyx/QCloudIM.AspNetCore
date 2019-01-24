 

using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Message.Contents
{
	 
	public class FileMsgContent : MsgContent
	{
 

	    [JsonProperty("UUID")]
	    public  string Uuid { get; set; }

	    [JsonProperty("FileSize")]
        public  long FileSize { get; set; }

	    [JsonProperty("FileName")]
        public  string Filename { get; set; }
	}

}
 
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Message.Contents
{
	 
	public class SoundMsgContent : MsgContent
	{
    

	    [JsonProperty("UUID")]
	    public  string Uuid { get; set; }


	    [JsonProperty("Size")]
	    public  long Size { get; set; }

        [JsonProperty("Second")]
	    public  int Seconds { get; set; }
	}

}
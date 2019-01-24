 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Message.Contents
{
 
	public class ImageMsgContent : MsgContent
	{
        [JsonProperty("UUID")]
	    public  string Uuid { get; set; }


	    [JsonProperty("ImageFormat")]
	    public  int ImageFormat { get; set; }


	    [JsonProperty("ImageInfoArray")]
	    public  IList<ImageInfo> ImageInfoArray { get; set; }
	}

    public class ImageInfo
    {
        
        [JsonProperty("Type")]
        public  int Type { get; set; }

        [JsonProperty("Size")]
        public  long Size { get; set; }

        [JsonProperty("Width")]
        public  int Width { get; set; }

        [JsonProperty("Height")]
        public  int Height { get; set; }

        [JsonProperty("URL")]
        public  string Url { get; set; }
    }

}
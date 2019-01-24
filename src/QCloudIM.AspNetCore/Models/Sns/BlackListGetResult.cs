using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
	 
	public class BlackListGetResult : QCloudIMResult
	{
	    [JsonProperty("BlackListItem")]
        public  IList<BlackListItem>  BlackListItem { get; }

	    [JsonProperty("StartIndex")]
        public  int StartIndex { get; set; }

	    [JsonProperty("CurrentSequence")]
        public  long CurrentSequence { get; set; }
	}
    public class BlackListItem
    {
         [JsonProperty("Black_Account")]
        public string BlackAccount { get; set; }


        [JsonProperty("BlackTimeStamp")]
        public long BlackTimestamp { get; set; }
    }

}
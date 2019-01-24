 
using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Friend;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
	 

	public class FriendGetAllResult : QCloudIMResult
	{ 

            [JsonProperty("NeedUpdateAll")]
	    public  string NeedUpdateAll { get; set; }

	    [JsonProperty("TimeStampNow")]
        public  long TimestampNow { get; set; }

	    [JsonProperty("StartIndex")]
        public  int StartIndex { get; set; }

	    [JsonProperty("InfoItem")]
        public  IList<InfoItem> InfoItem { get; set; }

	    [JsonProperty("CurrentStandardSequence")]
        public  int CurrentStandardSequence { get; set; }

	    [JsonProperty("FriendNum")]
        public  int FriendNum { get; set; }
	}

}
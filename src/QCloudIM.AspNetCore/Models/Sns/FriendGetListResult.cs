 
using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Friend;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
 

	public class FriendGetListResult : QCloudIMResult
	{ 

            [JsonProperty("InfoItem")]
	    public  IList<InfoItem> InfoItem { get; set; }

	    [JsonProperty("Fail_Account")]
        public  IList<string> FailAccount { get; set; }

	    [JsonProperty("Invalid_Account")]
        public  IList<string> InvalidAccount { get; set; }
	}

}
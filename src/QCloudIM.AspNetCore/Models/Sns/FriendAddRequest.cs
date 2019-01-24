using QCloudIM.AspNetCore.Models.Friend;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
	 
	public class FriendAddRequest : QCloudIMRequest
	{ 

            [JsonProperty("From_Account")]
	    public  string FromAccount { get; set; }

	    [JsonProperty("AddFriendItem")]
        public  IList<AddFriendItem> AddFriendItem { get; set; }

	    [JsonProperty("AddType")]
        public  string AddType { get; set; }

	    [JsonProperty("ForceAddFlags")]
        public  int ForceAddFlags { get; set; }
	}

}
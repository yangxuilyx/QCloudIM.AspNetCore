 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
 
	public class FriendGetListRequest : QCloudIMRequest
	{
        
	    [JsonProperty("From_Account")]
        public  string FromAccount { get; set; }

        [JsonProperty("To_Account")]
	    public  IList<string> ToAccount { get; set; }
	    [JsonProperty("TagList")]

        public  IList<string> TagList { get; set; }
	}

}
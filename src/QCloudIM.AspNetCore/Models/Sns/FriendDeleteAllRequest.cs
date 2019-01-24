 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
	 
	public class FriendDeleteAllRequest : QCloudIMRequest
	{
        [JsonProperty("From_Account")]
	    public  string FromAccount { get; set; }
	}

}
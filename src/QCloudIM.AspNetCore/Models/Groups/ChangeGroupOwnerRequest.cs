using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
 
	public class ChangeGroupOwnerRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("NewOwner_Account")]
        public  string NewOwnerAccount { get; set; }
	}

}
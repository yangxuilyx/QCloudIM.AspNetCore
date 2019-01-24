
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class DestroyGroupRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }
	}

}
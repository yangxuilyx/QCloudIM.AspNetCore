using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	
	public class GetGroupShuttedUinRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }
	}

}
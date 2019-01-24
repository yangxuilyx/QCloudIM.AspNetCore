using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	
	public class CreateGroupResult : QCloudIMResult
	{
       
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }
	}

}
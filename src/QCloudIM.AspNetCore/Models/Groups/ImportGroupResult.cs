 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class ImportGroupResult : QCloudIMResult
	{
 
        [JsonProperty("GroupId")]
	    public  string GroupId { get; set; }
	}

}
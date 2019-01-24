 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
	 
	public class GroupDeleteResult : QCloudIMResult
	{
 
            [JsonProperty("CurrentSequence")]
	    public virtual int CurrentSequence { get; set; }
	}

}
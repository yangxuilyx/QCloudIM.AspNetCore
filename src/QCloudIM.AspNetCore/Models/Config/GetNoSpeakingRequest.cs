 

using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Config
{
	

	public class GetNoSpeakingRequest : QCloudIMRequest
	{
 
        [JsonProperty("Get_Account")]
		public  string GetAccount { get; set; }

	}

}
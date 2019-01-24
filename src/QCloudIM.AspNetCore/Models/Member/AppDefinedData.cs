 
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Member
{
 
	public class AppDefinedData
	{
 
        [JsonProperty("Key")]
	    public virtual string Key { get; set; }

	    [JsonProperty("Value")]
        public virtual string Value { get; set; }
	}

}
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Profile
{
	 
	public class PortraitSetRequest : QCloudIMRequest
	{
        
	    [JsonProperty("From_Account")]
        public virtual string FromAccount { get; set; }

        [JsonProperty("ProfileItem")]
	    public virtual IList<Portrait.ProfileItem> TagList { get; set; }
	}

}
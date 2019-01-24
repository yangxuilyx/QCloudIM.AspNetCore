 
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
	 
	public class GroupDeleteRequest : QCloudIMRequest
	{
 

            [JsonProperty("From_Account")]
	    public   string FromAccount { get; set; }

	    [JsonProperty("GroupName")]
        public   IList<string> GroupName { get; set; }
	}

}
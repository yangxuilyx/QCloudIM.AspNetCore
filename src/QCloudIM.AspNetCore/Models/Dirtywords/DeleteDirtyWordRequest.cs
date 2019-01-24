 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Dirtywords
{
 

	public class DeleteDirtyWordRequest : QCloudIMRequest
	{
 
            [JsonProperty("DirtyWordsList")]
	    public virtual IList<string> DirtyWordsList { get; set; }
	}

}
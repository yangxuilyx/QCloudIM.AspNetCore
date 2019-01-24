 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Dirtywords
{
	 
	public class GetDirtyWordResult : QCloudIMResult
	{ 
            [JsonProperty("DirtyWordsList")]
	    public virtual IList<string> DirtyWordsList { get; set; }
	}

}
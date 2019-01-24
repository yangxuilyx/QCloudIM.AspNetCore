 

using System.Collections.Generic;
using Newtonsoft.Json;
 

namespace QCloudIM.AspNetCore.Models.OLogin
{
	 
	public class MultiAccountImportResult : QCloudIMResult
	{
	    public MultiAccountImportResult() : base()
		{
		}

        [JsonProperty("FailAccounts")]
		public virtual IList<string> FailAccounts { get; set; }
	}

}
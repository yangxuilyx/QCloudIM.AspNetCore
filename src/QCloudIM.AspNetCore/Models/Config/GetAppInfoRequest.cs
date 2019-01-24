using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.config
{
 
	public class GetAppInfoRequest : QCloudIMRequest
	{
 
	 
        [JsonProperty("RequestField")]
        public  IList<string> RequestField
		{
            get;set;
		}

	}

}
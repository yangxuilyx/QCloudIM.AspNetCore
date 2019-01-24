 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.OpenIm
{
 
	public class QueryStateRequest : QCloudIMRequest
	{
 
		private IList<string> toAccount;
		public QueryStateRequest(IList<string> toAccount)
		{
			this.toAccount = toAccount;
		}

        [JsonProperty("To_Account")]
		public  IList<string> ToAccount
		{
			get
			{
				return toAccount;
			}
			set
			{
				this.toAccount = value;
			}
		}

	}

}
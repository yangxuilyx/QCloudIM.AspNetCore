 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.OLogin
{
 
	public class MultiAccountImportRequest : QCloudIMRequest
	{
 
		private IList<string> _accounts;

		public MultiAccountImportRequest() : base()
		{
		}

        [JsonProperty("Accounts")]
		public virtual IList<string> Accounts
		{
			get
			{
				return _accounts;
			}
			set
			{
				this._accounts = value;
			}
		}

	}

}
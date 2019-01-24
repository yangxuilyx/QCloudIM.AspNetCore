 

using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.OLogin
{
	 
	public class KickRequest : QCloudIMRequest
	{
  
		private string _identifier;

		public KickRequest() : base()
		{
		}

	    [JsonProperty("Identifier")]
        public virtual string Identifier
		{
			get
			{
				return _identifier;
			}
			set
			{
				this._identifier = value;
			}
		}

	}

}
 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Svc
{
	 

	public class GetHistoryRequest : QCloudIMRequest
	{
  
            [JsonProperty("ChatType")]
	    public virtual string ChatType { get; set; }

	    [JsonProperty("MsgTime")]
        public virtual long MsgTime { get; set; }
	}

}
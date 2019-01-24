 

using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class GroupMsgGetSimpleRequest : QCloudIMRequest
	{
         
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("ReqMsgNumber")]
        public  int ReqMsgNumber { get; set; }

	    [JsonProperty("ReqMsgSeq")]
        public  long? ReqMsgSeq { get; set; }
	}

}
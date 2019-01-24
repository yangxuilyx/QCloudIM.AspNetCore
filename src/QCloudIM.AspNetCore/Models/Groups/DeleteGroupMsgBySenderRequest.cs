using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class DeleteGroupMsgBySenderRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("Sender_Account")]
        public  string SenderAccount { get; set; }
	}

}
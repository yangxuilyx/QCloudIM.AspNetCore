 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 

	public class SetUnreadMsgNumRequest : QCloudIMRequest
	{
         
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

        [JsonProperty("Member_Account")]
	    public  string MemberAccount { get; set; }

	    [JsonProperty("UnreadMsgNum")]
        public  int UnreadMsgNum { get; set; }
	}

}
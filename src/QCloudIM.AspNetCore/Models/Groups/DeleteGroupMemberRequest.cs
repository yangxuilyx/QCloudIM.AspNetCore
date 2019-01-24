using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
 
	public class DeleteGroupMemberRequest : QCloudIMRequest
	{ 
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("Silence")]
        public  int Silence { get; set; }

	    [JsonProperty("Reason")]
        public  string Reason { get; set; }

	    [JsonProperty("MemberToDel_Account")]
        public  IList<string> MemberToDelAccount { get; set; }
	}

}
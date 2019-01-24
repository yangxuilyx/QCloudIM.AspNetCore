using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 

	public class GetGroupMemberInfoRequest : QCloudIMRequest
	{
         
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("Limit")]
        public  long? Limit { get; set; }

	    [JsonProperty("Offset")]
        public  long? Offset { get; set; }

	    [JsonProperty("MemberInfoFilter")]
        public  IList<string> MemberInfoFilter { get; set; }

	    [JsonProperty("MemberRoleFilter")]
        public  IList<string> MemberRoleFilter { get; set; }

	    [JsonProperty("AppDefinedDataFilter_GroupMember")]
        public  IList<string> AppDefinedDataFilterForGroupMember { get; set; }
	}

}
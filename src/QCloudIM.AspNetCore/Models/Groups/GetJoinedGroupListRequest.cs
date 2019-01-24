 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class GetJoinedGroupListRequest : QCloudIMRequest
	{

	    [JsonProperty("Member_Account")]
        public  string MemberAccount { get; set; }

	    [JsonProperty("Limit")]
        public  long? Limit { get; set; }

	    [JsonProperty("Offset")]
        public  long? Offset { get; set; }

	    [JsonProperty("GroupType")]
        public  string GroupType { get; set; }

	    [JsonProperty("ResponseFilter")]
        public JoinedGroupResponseFilter ResponseFilter {get;set;}

	   
	}
    public class JoinedGroupResponseFilter
    {

        [JsonProperty("GroupBaseInfoFilter")]
        public IList<string> GroupBaseInfoFilter { get; set; }

        [JsonProperty("SelfInfoFilter")]
        public IList<string> SelfInfoFilter { get; set; }
    }
}
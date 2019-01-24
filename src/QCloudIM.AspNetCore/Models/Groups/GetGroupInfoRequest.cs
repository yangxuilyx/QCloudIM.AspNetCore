using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class GetGroupInfoRequest : QCloudIMRequest
	{
		
 

	    [JsonProperty("GroupIdList")]
        public  IList<string> GroupIdList { get; set; }


	    [JsonProperty("ResponseFilter")]
        public  ResponseFilter ResponseFilter
		{
	        get; set;
        }

		 
	}
    public class ResponseFilter
    {
        
        [JsonProperty("GroupBaseInfoFilter")]
        public IList<string> GroupBaseInfoFilter { get; set; }

        [JsonProperty("MemberInfoFilter")]
        public IList<string> MemberInfoFilter { get; set; }

        [JsonProperty("AppDefinedDataFilter_Group")]
        public IList<string> AppDefinedDataFilterForGroup { get; set; }

        [JsonProperty("AppDefinedDataFilter_GroupMember")]
        public IList<string> AppDefinedDataFilterForGroupMember { get; set; }
    }
}
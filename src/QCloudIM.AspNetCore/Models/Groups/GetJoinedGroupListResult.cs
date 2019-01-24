

using QCloudIM.AspNetCore.Models.Member;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class GetJoinedGroupListResult : QCloudIMResult
	{
        
	    [JsonProperty("TotalCount")]
        public  long TotalCount { get; set; }

	    [JsonProperty("GroupIdList")]
        public  IList<GroupId> GroupIdList { get; set; }
	}

}
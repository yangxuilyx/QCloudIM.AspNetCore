
using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Member;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class GetGroupListResult : QCloudIMResult
	{
         
	    [JsonProperty("GroupIdList")]
        public IList<GroupId> GroupIdList { get; set; }
	    [JsonProperty("Next")]
        public long Next { get; set; }
	    [JsonProperty("TotalCount")]
        public long TotalCount { get; set; }
	}

}
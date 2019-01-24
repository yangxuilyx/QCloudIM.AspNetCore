using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Member;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 

	public class GetGroupMemberInfoResult : QCloudIMResult
	{
         
	    [JsonProperty("MemberNum")]
        public  int MemberNum { get; set; }

	    [JsonProperty("MemberList")]
        public  IList<MemberListResultItem> MemberList { get; set; }
	}

}
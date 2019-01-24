using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 
	public class AddGroupMemberResult : QCloudIMResult
	{
		
 
	    [JsonProperty("MemberList")]
        public  IList<MemberListItem> MemberList { get; set; }
	}
   

}
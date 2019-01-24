using QCloudIM.AspNetCore.Models.Member;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
	public class GetGroupInfoResult : QCloudIMResult
	{
        [JsonProperty("GroupInfo")]
        public  IList<GroupInfo> GroupInfo { get; set; }
		 
	}
    public class GroupInfo
    {
        
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("ErrorCode")]
        public int ErrorCode { get; set; }

        [JsonProperty("ErrorInfo")]
        public string ErrorInfo { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Introduction")]
        public string Introduction { get; set; }

        [JsonProperty("Notification")]
        public string Notification { get; set; }

        [JsonProperty("FaceUrl")]
        public string FaceUrl { get; set; }

        [JsonProperty("Owner_Account")]
        public string OwnerAccount { get; set; }

        [JsonProperty("CreateTime")]
        public long CreateTime { get; set; }

        [JsonProperty("LastInfoTime")]
        public long LastInfoTime { get; set; }

        [JsonProperty("LastMsgTime")]
        public long LastMsgTime { get; set; }

        [JsonProperty("NextMsgSeq")]
        public long NextMsgSeq { get; set; }

        [JsonProperty("MemberNum")]
        public int MemberNum { get; set; }

        [JsonProperty("MaxMemberNum")]
        public int MaxMemberNum { get; set; }

        [JsonProperty("ApplyJoinOption")]
        public string ApplyJoinOption { get; set; }

        [JsonProperty("AppDefinedData")]
        public IList<AppDefinedData> AppDefinedData { get; set; }

        [JsonProperty("MemberList")]
        public IList<MemberListItem> MemberList { get; set; }
    }

}
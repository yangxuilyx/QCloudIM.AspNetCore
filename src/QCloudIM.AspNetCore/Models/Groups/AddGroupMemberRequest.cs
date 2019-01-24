using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{
    public class AddGroupMemberListItem
    {

        [JsonProperty("Member_Account")]
        public string MemberAccount { get; set; }
    }
    public class AddGroupMemberRequest : QCloudIMRequest
    {
        /// <summary>
        /// 用户自定义群组ID（选填）为了使得群组ID更加简单，便于记忆传播，腾讯云支持APP在通过REST
        /// API创建群组时自定义群组ID。详情参见：自定义群组ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("Silence")]
        public int Silence { get; set; }

        [JsonProperty("MemberList")]
        public IList<AddGroupMemberListItem> MemberList { get; set; }
    }


}
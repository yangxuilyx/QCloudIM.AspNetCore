using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Member;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Groups
{


    public class CreateGroupRequest : QCloudIMRequest
    {
        /// <summary>
        /// 群主的UserId（选填） 群主id，自动添加到群成员中。如果不填，群没有群主。
        /// </summary>
        [JsonProperty("Owner_Account")]
        public string OwnerAccount { get; set; }
        /// <summary>
        /// ,群组形态，包括Public（公开群），Private（私密群），ChatRoom（聊天室），AVChatRoom（互动直播聊天室）。
        /// </summary>
        [JsonProperty("Type")]
        public string Type { get; set; }
        /// <summary>
        /// 群名称（必填）最长30字节。
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 群简介（选填）最长240字节
        /// </summary>
        [JsonProperty("Introduction")]
        public string Introduction { get; set; }
        /// <summary>
        /// 群公告（选填）最长300字节
        /// </summary>
        [JsonProperty("Notification")]
        public string Notification { get; set; }
        /// <summary>
        /// 群头像URL（选填）最长100字节
        /// </summary>
        [JsonProperty("FaceUrl")]
        public string FaceUrl { get; set; }
        /// <summary>
        /// 最大群成员数量（选填）最大为10000，不填默认为200个。
        /// </summary>
        [JsonProperty("MaxMemberCount")]
        public int? MaxMemberCount { get; set; }
        /// <summary>
        /// 申请加群处理方式（选填）包含FreeAccess（自由加入），NeedPermission（需要验证），DisableApply（禁止加群），
	    ///不填默认为NeedPermission（需要验证）
        /// </summary>
	    [JsonProperty("ApplyJoinOption")]
        public string ApplyJoinOption { get; set; }
        /// <summary>
        /// 用户自定义群组ID（选填）为了使得群组ID更加简单，便于记忆传播，腾讯云支持APP在通过REST
        /// API创建群组时自定义群组ID。详情参见：自定义群组ID。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// 初始群成员列表，最多500个（选填）默认情况是没有的，需要开通，详情参见：自定义字段。
        /// </summary>
	    [JsonProperty("MemberList")]
        public IList<MemberListItem> MemberList { get; set; }

        /// <summary>
        ///  群组维度的自定义字段（选填）
        /// </summary>
	    [JsonProperty("AppDefinedData")]
        public IList<AppDefinedData> AppDefinedData { get; set; }
    }

}


using QCloudIM.AspNetCore.Models.Member;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Groups
{
	 

	public class ModifyGroupBaseInfoRequest : QCloudIMRequest
	{
        [JsonProperty("Name")]
        public  string Name { get; set; }

	    [JsonProperty("Introduction")]
        public  string Introduction { get; set; }

	    [JsonProperty("Notification")]
        public  string Notification { get; set; }

	    [JsonProperty("FaceUrl")]
        public  string FaceUrl { get; set; }

	    [JsonProperty("MaxMemberNum")]
        public  int MaxMemberCount { get; set; }

	    [JsonProperty("ApplyJoinOption")]
        public  string ApplyJoinOption { get; set; }

	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

        [JsonProperty("AppDefinedData")]
	    public  IList<AppDefinedData> AppDefinedData { get; set; }
	}

}
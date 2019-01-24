
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Profile
{
	

	public class PortraitGetResult : QCloudIMResult
	{
	    [JsonProperty("UserProfileItem")]
        public  IList<UserProfileItem>  UserProfileItem {get; set;}
	 
        [JsonProperty("Fail_Account")]
		public  IList<string> FailAccount { get; set; }

	    [JsonProperty("Invalid_Account")]
        public  IList<string> InvalidAccount { get; set; }
	}

    public class UserProfileItem
    {
        [JsonProperty("To_Account")]
        public  string ToAccount { get; set; }

        [JsonProperty("ProfileItem")]
        public  IList<Portrait.ProfileItem> ProfileItem { get; set; }

        [JsonProperty("ResultCode")]
        public  int ResultCode { get; set; }

        [JsonProperty("ResultInfo")]
        public  string ResultInfo { get; set; }
    }

}
 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Friend
{
	 
	public class InfoItem
	{
		
	    [JsonProperty("Info_Account")]
        public  string InfoAccount { get; set; }


	    [JsonProperty("SnsProfileItem")]
        public  IList<SnsProfileItem> SnsProfileItem
	    {
	        get;
	        set;
	    }

		 
	}

    public class SnsProfileItem
    {

        [JsonProperty("Tag")]
        public string Tag { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}
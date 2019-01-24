

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Message
{
    public class AndroidInfo
    {

        [JsonProperty("Sound")]
        public string Sound { get; set; }
    }
    public class ApnsInfo : AndroidInfo
    {
        [JsonProperty("BadgeMode")]
        public int BadgeMode { get; set; }
    }

    public class OfflinePushInfo
    {



        [JsonProperty("PushFlag")]
        public int PushFlag { get; set; }

        [JsonProperty("Desc")]
        public string Desc { get; set; }

        [JsonProperty("Ext")]
        public string Ext { get; set; }

        [JsonProperty("AndroidInfo")]
        public AndroidInfo AndroidInfo { get; set; }

        [JsonProperty("ApnsInfo")]

        public ApnsInfo ApnsInfo
        {
            get; set;
        }

    }

}
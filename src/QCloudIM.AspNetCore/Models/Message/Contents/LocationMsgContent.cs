
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Message.Contents
{
    public class LocationMsgContent : MsgContent
    {

        [JsonProperty("Desc")]
        public  string Desc { get; set; }

        [JsonProperty("Latitude")]
        public  double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public  double Longitude { get; set; }
    }

}
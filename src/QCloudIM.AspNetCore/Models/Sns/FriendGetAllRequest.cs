 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{
    public class FriendGetAllRequest : QCloudIMRequest
    {

        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("TimeStamp")]
        public long Timestamp { get; set; }

        [JsonProperty("StartIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("TagList")]
        public IList<string> TagList { get; set; }

        [JsonProperty("LastStandardSequence")]
        public int LastStandardSequence { get; set; }

        [JsonProperty("GetCount")]
        public int Count { get; set; }
    }

}
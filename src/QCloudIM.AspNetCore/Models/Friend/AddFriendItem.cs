

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Friend
{

    public class AddFriendItem
    {
        [JsonProperty("To_Account")]
        public string ToAccount { get; set; }

        [JsonProperty("AddSource")]
        public string AddSource { get; set; }

        [JsonProperty("Remark")]
        public string Remark { get; set; }

        [JsonProperty("GroupName")]
        public IList<string> GroupName { get; set; }

        [JsonProperty("AddWording")]
        public string AddWording { get; set; }

        [JsonProperty("AddTime")]
        public long? AddTime
        {
            get; set;
        }
        [JsonProperty("CustomItem")]
        public IList<CustomItem> CustomItem { get; set; }
    }
    public class CustomItem
    {
        [JsonProperty("Tag")]
        public string Tag { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}
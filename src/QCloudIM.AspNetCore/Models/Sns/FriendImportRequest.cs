

using QCloudIM.AspNetCore.Models.Friend;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIM.AspNetCore.Models.Sns
{

    public class FriendImportRequest : QCloudIMRequest
    {
        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("AddFriendItem")]
        public IList<AddFriendItem> AddFriendItem { get; set; }
    }

}
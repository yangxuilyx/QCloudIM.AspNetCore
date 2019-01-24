 

using System;
using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Message;
using Newtonsoft.Json;
 

namespace QCloudIM.AspNetCore.Models.OpenIm
{
 
    
    
	public class BatchSendMsgRequest : QCloudIMRequest
	{
        
            [JsonProperty("SyncOtherMachine")]
        public virtual int SyncOtherMachine { get; set; }

        [JsonProperty("From_Account")]
	    public virtual string FromAccount { get; set; }

        [JsonProperty("To_Account")]
	    public virtual IList<string> ToAccount { get; set; }

	    [JsonProperty("MsgLifeTime")]
        public virtual int MsgLifeTime { get; set; }

	    [JsonProperty("MsgRandom")]
        public virtual int MsgRandom { get; set; }

	    [JsonProperty("MsgTimeStamp")]
        public virtual long MsgTimestamp { get; set; }

	    [JsonProperty("MsgBody")]
        public virtual IList<MsgBodyItem> MsgBody { get; set; }

	    [JsonProperty("OfflinePushInfo")]
        public virtual OfflinePushInfo OfflinePushInfo { get; set; }
	}

}
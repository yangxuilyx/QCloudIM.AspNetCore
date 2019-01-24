 

using System.Collections.Generic;
using QCloudIM.AspNetCore.Models.Message;
using Newtonsoft.Json;
 

namespace QCloudIM.AspNetCore.Models.OpenIm
{
	　
	public class BatchSendMsgResult : QCloudIMResult
	{ 

            [JsonProperty("ErrorList")]
	    public   IList<ErrorListItem> ErrorList { get; set; }
	}


}
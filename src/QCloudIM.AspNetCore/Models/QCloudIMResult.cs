using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models
{
    /// <summary>
    /// 请求结果返回基类
    /// </summary>
    public class QCloudIMResult
    {
        [JsonProperty("ActionStatus")]
        public string ActionStatus { get; set; }


        [JsonProperty("ErrorInfo")]
        public string ErrorInfo { get; set; }


        [JsonProperty("ErrorCode")]
        public int ErrorCode { get; set; }


        [JsonProperty("ErrorDisplay")]
        public string ErrorDisplay { get; set; }

        [JsonIgnore]
        public bool Success => "OK".Equals(ActionStatus);
    }

}
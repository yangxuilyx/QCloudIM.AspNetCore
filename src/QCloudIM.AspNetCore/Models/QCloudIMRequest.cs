using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models
{
    /// <summary>
    /// IM请求基类
    /// </summary>
	public class QCloudIMRequest
    {
        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
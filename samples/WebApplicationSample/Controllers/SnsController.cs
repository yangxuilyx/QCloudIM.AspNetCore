using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QCloudIM.AspNetCore.Clients.Sns;
using QCloudIM.AspNetCore.Models.Sns;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SnsController : Controller
    {
        private IQCloudIMSnsClient _cloudImSnsClient;

        public SnsController(IQCloudIMSnsClient cloudImSnsClient)
        {
            _cloudImSnsClient = cloudImSnsClient;
        }

        [HttpPost]
        public async Task<FriendAddResult> FriendAddAsync([FromBody]FriendAddRequest request)
        {
            return await _cloudImSnsClient.FriendAddAsync(request);
        }
    }
}
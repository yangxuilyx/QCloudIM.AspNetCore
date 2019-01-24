using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QCloudIM.AspNetCore.Groups;
using QCloudIM.AspNetCore.Models.Groups;

namespace WebApplicationSample.Controllers
{
    [Route("api/[controller]/[action]")]
    public class GroupController : Controller
    {
        private IQCloudIMGroupClient _groupClient;

        public GroupController(IQCloudIMGroupClient groupClient)
        {
            _groupClient = groupClient;
        }

        [HttpPost]
        public async Task<ActionResult<GetGroupListResult>> GetGroupListAsync(GetGroupListRequest request)
        {
            return await _groupClient.GetGroupListAsync(request);
        }
    }
}
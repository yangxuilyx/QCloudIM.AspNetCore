using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QCloudIM.AspNetCore.Clients.Group;
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
        public async Task<ActionResult<GetGroupListResult>> GetGroupList([FromBody]GetGroupListRequest request)
        {
            return await _groupClient.GetGroupListAsync(request);
        }

        [HttpPost]
        public async Task<ActionResult<CreateGroupResult>> CreateGroup([FromBody] CreateGroupRequest request)
        {
            return await _groupClient.CreateGroupAsync(request);
        }

        [HttpPost]
        public async Task<ActionResult<GetGroupInfoResult>> GetGroupInfo([FromBody] GetGroupInfoRequest request)
        {
            return await _groupClient.GetGroupInfoAsync(request);
        }
    }
}
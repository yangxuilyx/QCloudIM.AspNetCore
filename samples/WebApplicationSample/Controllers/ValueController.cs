using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QCloudIM.AspNetCore;
using QCloudIM.AspNetCore.Groups;
using QCloudIM.AspNetCore.Models.Groups;

namespace WebApplicationSample.Controllers
{
    public class ValueController : Controller
    {
        private readonly IQCloudIMGroupClient _qCloudImGroupClient;

        public ValueController(IQCloudIMGroupClient qCloudImGroupClient)
        {
            _qCloudImGroupClient = qCloudImGroupClient;
        }

        [Route("api/values")]
        public async Task<ActionResult<GetGroupListResult>> Index()
        {
            var getGroupListResponse = await _qCloudImGroupClient.GetGroupList(new GetGroupListRequest());

            return getGroupListResponse;
        }
    }
}
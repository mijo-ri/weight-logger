using Application.Profiles;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class ProfilesController : BaseApiController
    {
        [HttpGet("{userName}/logs")]
        public async Task<IActionResult> GetUserLogs(string userName)
        {
            return HandleResult(await Mediator.Send(new ListLogs.Query { UserName = userName }));
        }
    }
}

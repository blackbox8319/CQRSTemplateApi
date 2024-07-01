using Application.Queries.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static API.Contracts.ApiRoutes;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class Authentication : BaseController
    {
        [HttpPost(AuthenticationRoutes.Login)]
      
        public async Task<IActionResult> Login([FromBody] LoginQuery login)
        {
            var result = await Mediator.Send(login);
            return result.Match<IActionResult>(Ok, NotFound);
        }
    }
}

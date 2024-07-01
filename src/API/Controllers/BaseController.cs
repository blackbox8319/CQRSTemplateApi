using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private IMediator? _mediator = null!;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
    }
}

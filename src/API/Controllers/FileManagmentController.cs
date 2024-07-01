using Application.Commands.Attachments;
using Application.Queries.Attachments;
using Microsoft.AspNetCore.Mvc;
using static API.Contracts.ApiRoutes;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FileManagmentController : BaseController
    {
        //[HttpPost(FileManagmentRoutes.AttachDocument)]
        //public async Task<IActionResult> AttachDocument(IFormFile file)
        //{
        //    var result = await Mediator.Send(new AttachCommand { File = file, });
        //    return result.Match<IActionResult>(Ok, NotFound);
        //}

        //[HttpDelete(FileManagmentRoutes.DeleteDocument)]
        //public async Task<IActionResult> DeleteDocument([FromRoute] string documentName)
        //{
        //    var result = await Mediator.Send(new DeleteDocumetsQuery { DocumentName = documentName });
        //    return result.Match<IActionResult>(Ok, NotFound);
        //}
    }
}

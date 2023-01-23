using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PartyWorkspace.Web.Controllers
{
    [ApiController]
    public class SavedPartiesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [Route("/api/savedparties")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

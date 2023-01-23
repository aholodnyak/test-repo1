using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PartyWorkspace.Web.Controllers
{
    [ApiController]
    public class ViewedController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [Route("api/users/viewed")]
        public IActionResult Get()
        {
            var ids = new List<Guid>
            {
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid()
            };
            return Ok(ids);
        }
    }
}

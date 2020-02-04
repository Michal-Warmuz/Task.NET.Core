using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Infrastructure.Services.Interface;

namespace Task.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService guestService;

        public GuestController(IGuestService _guestService)
        {
            guestService = _guestService;
        }


        [HttpGet]
        [Route("GetPeters")]
        public async Task<IActionResult> GetPeters()
        {
            return Ok(await guestService.GetPetersAsync());
        }
    }
}
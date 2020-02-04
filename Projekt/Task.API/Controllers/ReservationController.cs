using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Infrastructure.Commands;
using Task.Infrastructure.Services.Interface;

namespace Task.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var payload = await reservationService.GetAllAsync();
            return Ok(payload);
        }


        [HttpPost]
        [Route("SaveReservationWithGuests")]
        public IActionResult SaveReservationWithGuests([FromBody]ReservationWithGuestsCommand  command)
        {
            try
            {
                reservationService.SaveReservationWithGuests(command);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using 会議室予約.Domain.予約;
using 会議室予約.UseCase;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReserveController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ReserveController> _logger;

        public ReserveController(ILogger<ReserveController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post(Reserve reserve)
        {
            var request = new 予約Request();
            request.よやくしゃ = new 予約者Id();

            return new JsonResult(reserve);
        }
    }
}

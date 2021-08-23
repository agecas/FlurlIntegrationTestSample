using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlurlDemo.ApiApp.App;

namespace FlurlDemo.ApiApp.Controllers
{
    [ApiController]
    [Route("futurama")]
    public class FuturamaController : ControllerBase
    {
        private readonly SampleClient _client;
        private readonly ILogger<FuturamaController> _logger;

        public FuturamaController(SampleClient client, ILogger<FuturamaController> logger)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public Task<IReadOnlyList<Episode>> Get() => _client.GetFuturamaInfo();
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public IEnumerable<int> Get()
        {
            this._logger.LogInformation("Endpoint Called");
            return new[] { 1, 2, 3 };
        }
    }
}
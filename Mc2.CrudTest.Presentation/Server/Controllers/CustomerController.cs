using Mc2.CrudTest.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Mc2.CrudTest.Domain.Generators;
using Mc2.CrudTest.Shared.Models;

namespace Mc2.CrudTest.Presentation.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public CustomerController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            List<Customer> response = CustomerGenerator.GenerateCustomers();
            IPAddress userIp = HttpContext.Request.HttpContext.Connection.RemoteIpAddress;
            _logger.LogDebug($"[Request from {userIp}: Serving Get() response: {string.Join("\n", response.ToList())}");
            return response;
        }
    }
}

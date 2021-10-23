using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tagbot.Service;

namespace TagBotApi.Controllers
{
    [ApiController]
    [Route("[controller]/{date}")]

    public class ServiceController : ControllerBase
    {
        private readonly ILogger<ServiceController> _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(string date)
        {
            string response = _sqlite(date);
            return response;
        }

        private string _sqlite(string date)
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = AppDomain.CurrentDomain.BaseDirectory + "../../../../";
            sqlite.databasePath = @"C:\Users\Frank\source\repos\TagBot\";
            return sqlite.getShow(date);
        }
    }
}

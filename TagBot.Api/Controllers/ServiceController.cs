using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tagbot.Service;

namespace TagBot.Api1.Controllers
{
    public class ServiceController : ApiController
    {
        private string _sqlite(string date)
        {
            Sqlite sqlite = new Sqlite();
            sqlite.databasePath = AppDomain.CurrentDomain.BaseDirectory + "../";
            return sqlite.getShow(date);
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string id)
        {
            string response = _sqlite(id);
            return response;
        }

    }
}

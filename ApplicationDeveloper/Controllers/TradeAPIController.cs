using ApplicationDeveloper.Data.Repositories;
using ApplicationDeveloper.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ApplicationDeveloper.Controllers
{
    public class TradeAPIController : ApiController
    {
        // GET: api/TradeAPI
        public IEnumerable<Trade> Get()
        {
            var repo = new TradeRepository();
            var trades = repo.GetTrades();
            return trades;
        }

        // GET: api/TradeAPI/5
        public string Get(int id)
        {
            return "value";
        }


    }
}

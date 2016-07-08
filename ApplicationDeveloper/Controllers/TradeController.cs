using ApplicationDeveloper.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationDeveloper.Controllers
{
    public class TradeController : Controller
    {
        // GET: Trade
        public ActionResult Index()
        {
            var repo = new TradeRepository();
            var trades = repo.GetTrades();
            return View(trades);
        }
        public ActionResult AjaxTrades()
        {
            return View();
        }
    }
}
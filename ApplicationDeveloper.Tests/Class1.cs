using ApplicationDeveloper.Controllers;
using ApplicationDeveloper.Data.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ApplicationDeveloper.Tests
{
    [TestFixture]
    public class ApplicationDeveloperTests
    {
        [Test]
        public void shouldReturnNumberOfTrades()
        {
            var sut = new TradeRepository();
            var trades = sut.GetTrades().ToList();

            Assert.That(trades.Count, Is.EqualTo(500));

        }
        [Test]
        public void shouldReturnViewName()
        {
            var sut = new TradeController();
            var view = sut.Index() as ViewResult;

            Assert.That(view.ViewName, Is.EqualTo("Index"));
        }
    }
}

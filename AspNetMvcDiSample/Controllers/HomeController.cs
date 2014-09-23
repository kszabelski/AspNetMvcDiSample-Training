using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcDiSample.Models;
using AspNetMvcDiSample.Tests;

namespace AspNetMvcDiSample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(decimal value, string sourceCurrency, string targetCurrency)
        {
            var inputMoney = new Money(value, sourceCurrency);

            ViewBag.Result = inputMoney;
            return View();
        }

    }
}

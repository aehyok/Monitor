using aehyok.Monitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aehyok.Monitor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            ServicesHelper servicesHelper = new ServicesHelper();
            servicesHelper.startService();
            return View();
        }
    }
}

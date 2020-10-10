using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VariableInActionResult.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1(string Username, string Password)
        {
            ViewBag.message = Username + " " + " " + Password;
            return View();
        }
    }
}
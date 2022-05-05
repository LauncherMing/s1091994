using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410919946.Controllers
{
    public class TestController : Controller
    {
        // GET: LMing
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HW1()
        {
            return View();
        }
        public ActionResult HW2()
        {
            return View();
        }
        public ActionResult HW3()
        {
            ViewBag.LMing = "27";
            ViewData["Barry"] = "OvO";
            return View();
        }
    }
}
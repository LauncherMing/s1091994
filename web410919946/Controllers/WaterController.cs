using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410919946.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(String name,float? weight)
        {
            String result = "";
            bool weightInput = false;
            if (weight.HasValue )
            {
                weightInput = true;
                result = (weight * 30) + "cc";
            }
            ViewBag.wI = weightInput;
            ViewBag.Name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}
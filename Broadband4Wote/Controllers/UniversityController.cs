using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadband4Wote.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Home() { return View("index"); }

        [HttpGet]
        public ActionResult ReviewStudnet() { return View(""); }

        [HttpPost]
        public ActionResult ReviewStudent()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ReviewActivity() { return View(); }

        [HttpPost]
        public ActionResult ReviewActivity(string key)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Uploadfile()
        {
            object str = "[{ }]"; 
            return Json(str, JsonRequestBehavior.AllowGet);
        }
    }
}
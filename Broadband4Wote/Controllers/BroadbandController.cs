using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Broadband4Wote.Controllers
{
    
    public class BroadbandController : Controller
    {
        // GET: Broadband
        public ActionResult Home() { return  View(); }

        [HttpGet]
        public ActionResult Approvelist() { return View(); }

        [HttpPost]
        public ActionResult Approvelist(string key) { return View(); }
        
    }
}
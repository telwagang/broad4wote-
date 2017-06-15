using Broadband4Wote.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadband4Wote.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Home() { return View("index"); }

        [HttpGet]
        public ActionResult Register() { return View(); }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Register(registerStudentViewModel stv)
        {
            if (ModelState.IsValid)
            {


            }
            return View();
        }

        [HttpGet]
        public ActionResult Reference(studentReference sr)
        {
            return View(sr);
        }

        [HttpPost]
        public ActionResult Reference()
        {
            return View();
        }
        [HttpGet]
        public ActionResult status()
        {
            return View();
        }

        [HttpPost]
        public ActionResult yes()
        {
            var userid = User.Identity.GetUserId();

            return RedirectToAction(nameof(Home));
        }
    }
}
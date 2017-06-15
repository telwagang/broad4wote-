using Broadband4Wote.Models;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Broadband4Wote.Controllers
{
    public class StudentController : Controller
    {

        internal  string keyReference { get; set; }
        // GET: Student
        [HttpGet]
        public ActionResult Home() { return View("index"); }

        [HttpGet]
        public ActionResult Register() { return View(); }

        [HttpGet]
        public ActionResult Steps() { return View("StepContainer"); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(registerStudentViewModel stv)
        {
            if (ModelState.IsValid)
            {
                //if (new UniverstyRules())
                //{

                //}
                return RedirectToAction(nameof(Dp));

            }
            return View();
        }

        [HttpGet]
        public ActionResult Reference(studentReference sr)
        {
            return View(sr);
        }

        [HttpGet]
        public ActionResult Dp() { return View("uploadpic"); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dp(profileViewModel pv)
        {
            HttpFileCollectionBase files = Request.Files;

            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFileBase file = files[i];
                string fname;


                fname = User.Identity.GetUserName();
                fname = Path.Combine(Server.MapPath("~/UserContent/StudnetContent/"), fname);
                file.SaveAs(fname);

            }
            return View();
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
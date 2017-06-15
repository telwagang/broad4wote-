using Broadband4Wote.DataLayer.DataContext;
using Broadband4Wote.Models;
using Broadband4Wote.Models.Rules;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Broadband4Wote.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public StudentController()
        {
        }

        public StudentController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: Student
        [HttpGet]
        public ActionResult Home() { return View("index"); }

        [HttpGet]
        public ActionResult Register() { return View(); }

        [HttpGet] 
        public ActionResult Steps() { return View("StepContainer"); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(registerStudentViewModel stv)
        {
            if (ModelState.IsValid)
            {
                if (await new UniverstyRules().RegisterStudent(stv, UserManager))
                {
                    return RedirectToAction(nameof(Dp));
                }
                

            }
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Reference()
        {
            var UserId = User.Identity.GetUserId();

            using (var db = new BroadBandContext())
            {
                var refere =  db.Reference.FirstOrDefault(C => C.ApplicationID.Equals(UserId));

                if (refere != null)
                {
                    return View(refere);
                }
            }
            return 
        }

        [HttpGet]
        public ActionResult Dp() { return View("uploadpic");  }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Dp(profileViewModel pv)
        {
            if (ModelState.IsValid)
            {
                if (await new UniverstyRules().UplaodStudentPic(pv))
                {
                    return RedirectToAction(nameof(Reference));
                }
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
using hiophop.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace hiophop.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Users = "jay@mail.com")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ////  var username = HttpContext.GetOwinContext()
            ////.GetUserManager<ApplicationUserManager>()
            ////.FindById(User.Identity.GetUserId()).Name;


            //     var  userName1 = username.ToList();
            //    var sortMusic = from m in userName1 select m;


            //    return View(sortMusic.ToList());
            // UserManager<ApplicationUser>

         ;

            return View();
        }
    }
}
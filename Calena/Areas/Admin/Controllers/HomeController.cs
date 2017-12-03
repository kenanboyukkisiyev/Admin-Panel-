using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;
using System.Web.Helpers;
namespace Calena.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult login(User usr)
        {
            User logined = db.Users.FirstOrDefault(u => u.Email == usr.Email);
            if (logined!=null)
            {
                if (Crypto.VerifyHashedPassword(logined.Password, usr.Password))
                {
                    Session ["logined"] = true;
                    return RedirectToAction("index", "dashbor");
                }

            }
            Session["loginEderror"] = "Username or Paswor";
            return RedirectToAction("index");
        }
    }
}
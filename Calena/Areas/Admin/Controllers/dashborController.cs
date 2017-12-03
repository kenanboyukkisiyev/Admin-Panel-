using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;

namespace Calena.Areas.Admin.Controllers
{
    public class dashborController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        // GET: Admin/dashbor
        public ActionResult Index()
        {
            if (Session["logined"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("index", "Home");
            }

           
        }

        public ActionResult Logout()
        {
            Session["logined"] = null;
            return RedirectToAction("index","home");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;
namespace Calena.Controllers
{
    public class HomeController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        public ActionResult Index()
        {
            ViewBag.home = db.Sliders.ToList();
            ViewBag.peoplesays = db.PepleeSays.ToList();
            ViewBag.about = db.Abouts.First();
            ViewBag.aboutservice = db.AboutServices.ToList();
            return View();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;

namespace Calena.Controllers
{
    public class AboutController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        // GET: About
        public ActionResult Index()
        {

            ViewBag.about = db.Abouts.First();
            ViewBag.aboutservice = db.AboutServices.ToList();
            ViewBag.Teams = db.Teams.OrderBy(t => t.OrderBy).ToList();
            return View();
        }
    }
}
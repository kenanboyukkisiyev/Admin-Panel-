using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;
namespace Calena.Controllers
{
    public class projectssingleController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        // GET: projectssingle
        public ActionResult Index()
        {
            ViewBag.projoct = db.Projects.ToList();
            ViewBag.projects = db.Catigories.ToList();


            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;
namespace Calena.Controllers
{
    public class ServicesController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        // GET: Services
        public ActionResult Index()
        {
            ViewBag.service = db.Services.ToList();
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;
namespace Calena.Controllers
{
    public class ProjectsController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        public ActionResult Index()
        {
          
            return View();
        }
    }
}
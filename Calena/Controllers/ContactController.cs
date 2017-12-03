using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calena.Models;
namespace Calena.Controllers
{
    public class ContactController : Controller
    {
        CalenaEntities db = new CalenaEntities();
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.contact = db.Contacts.ToList();
            return View();
        }
    }
}
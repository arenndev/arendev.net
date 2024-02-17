using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arendev.net.Models.Entity;

namespace arendev.net.Controllers
{
    public class ContactController : Controller
    {
        PortfolioEntities2 db = new PortfolioEntities2();
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact c)
        {
            db.Contacts.Add(c);
            db.SaveChanges();
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arendev.net.Models.Entity;

namespace arendev.net.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        PortfolioEntities2 db = new PortfolioEntities2();
        public ActionResult Experience()
        {
            var values = db.Experiences.ToList();
            return View(values);
        }

        public ActionResult AdminExperience()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arendev.net.Models.Entity;

namespace arendev.net.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        PortfolioEntities2 db = new PortfolioEntities2();
        public ActionResult Skill()
        {
            var values = db.Skills.ToList();
            return View(values);
        }

       
    }
}
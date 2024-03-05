using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arendev.net.Models.Entity;
using arendev.net.Repositories;

namespace arendev.net.Controllers.Admin
{
    public class ASkillController : Controller
    {
        PortfolioEntities2 db = new PortfolioEntities2();
        GenericRepository<Skill> repo = new GenericRepository<Skill>();

        // GET: ASkill
        public ActionResult AdminSkill()
        {
            var skill = repo.List();
            return View(skill);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill p)
        {
            p.CreateDate = DateTime.Now;
            repo.TAdd(p);
            return RedirectToAction("AdminSkill");
        }
    }    
       
}
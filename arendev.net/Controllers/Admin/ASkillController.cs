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

        public ActionResult RemoveSkill(int id)
        {
            Skill t = repo.Find(x => x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("AdminSkill");
        }

       

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            Skill t = repo.Find(x => x.Id == id);
           return View(t);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill p)
        {
            Skill t = repo.Find(x => x.Id == p.Id);
            t.Information = p.Information;
            t.Skill1 = p.Skill1;
            t.SkillLevel = p.SkillLevel;
            t.SkillLevelNumbered = p.SkillLevelNumbered;
            t.Status = p.Status;
            t.UpdateDate = DateTime.Now;
            repo.TUpdate(t);
            return RedirectToAction("AdminSkill");
        }
    }    
       
}
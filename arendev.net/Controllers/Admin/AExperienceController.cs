using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arendev.net.Repositories;
using arendev.net.Models.Entity;

namespace arendev.net.Controllers.Admin
{
    public class AExperienceController : Controller
    {
        ExperienceRepository repo = new ExperienceRepository();
        // GET: AExperience
        public ActionResult AdminExperience()
        {
            var experience = repo.List();
            return View(experience);
        }


        [HttpGet]
        public ActionResult ExperienceAdd()
        {
            return View();

        }

        [HttpPost]
        public ActionResult ExperienceAdd(Experience p)
        {
            repo.TAdd(p);
            return RedirectToAction("AdminExperience");
        }

        public ActionResult RemoveExperience(int id)
        {
            Experience t = repo.Find(x => x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("AdminExperience");
        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            Experience t = repo.Find(x => x.Id == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult UpdateExperience(Experience p)
        {
            Experience t = repo.Find(x => x.Id == p.Id);
            t.Employer = p.Employer;
            t.JobTitle = p.JobTitle;
            t.City = p.City;
            t.Country = p.Country;
            t.StartDate = p.StartDate;
            t.EndDate = p.EndDate;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("AdminExperience");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arendev.net.Models.Entity;
using arendev.net.Repositories;

namespace arendev.net.Controllers.Admin
{
    public class AEducationController : Controller
    {
        PortfolioEntities2 db = new PortfolioEntities2();
        GenericRepository<Education> repo = new GenericRepository<Education>();

        // GET: AEducation
        public ActionResult AdminEducation()
        {
            var education = repo.List();
            return View(education);
        }


        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(Education p)
        {
            p.CreateDate = DateTime.Now;
            repo.TAdd(p);
            return RedirectToAction("AdminEducation");
        }

        public ActionResult RemoveEducation(int id)
        {
            Education t = repo.Find(x => x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("AdminEducation");
        }


        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            Education t = repo.Find(x => x.Id == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult UpdateEducation(Education p)
        {
            Education t = repo.Find(x => x.Id == p.Id);
            t.Degree = p.Degree;
            t.School = p.School;
            t.City = p.City;
            t.Country = p.Country;
            t.StartDate = p.StartDate;
            t.EndDate = p.EndDate;
            t.CreateDate = DateTime.Now;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("AdminEducation");

        }
    }
}
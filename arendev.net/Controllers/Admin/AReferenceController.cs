using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arendev.net.Models.Entity;
using arendev.net.Repositories;

namespace arendev.net.Controllers.Admin
{

    public class AReferenceController : Controller
    {
        PortfolioEntities2 db = new PortfolioEntities2();
        GenericRepository<Reference> repo = new GenericRepository<Reference>();
        // GET: AReference
        public ActionResult AdminReference()
        {
            var reference = repo.List();
            return View(reference);
        }

        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddReference(Reference p)
        {
            p.CreateDate = DateTime.Now;
            repo.TAdd(p);
            return RedirectToAction("AdminReference");
        }


        public ActionResult RemoveReference(int id)
        {
            Reference t = repo.Find(x => x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("AdminReference");
        }


        [HttpGet]
        public ActionResult UpdateReference(int id)
        {
            Reference t = repo.Find(x => x.Id == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult UpdateReference(Reference p)
        {
            Reference t = repo.Find(x => x.Id == p.Id);
            t.Name = p.Name;
            t.Surname = p.Surname;
            t.JobTitle = p.JobTitle;
            t.Organization = p.Organization;
            t.Email = p.Email;
            t.Phone = p.Phone;
            t.UpdateDate = DateTime.Now;
            t.Status = p.Status;
            repo.TUpdate(t);
            return RedirectToAction("AdminReference");
        }

    }
}
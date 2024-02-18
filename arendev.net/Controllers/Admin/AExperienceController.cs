﻿using System;
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
    }
}
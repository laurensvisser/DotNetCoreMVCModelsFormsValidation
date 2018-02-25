using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMVCModelsFormsValidation.Models;
using DotNetCoreMVCModelsFormsValidation.Entities;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMVCModelsFormsValidation.Controllers
{
    public class MaaltijdController : Controller
    {
        private MaaltijdContext db;

        public MaaltijdController()
        {
            db = new MaaltijdContext();
        }

        public ViewResult Index()
        {
            return View(db.Maaltijd.ToList());
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Maaltijd maaltijd)
        {
            if (ModelState.IsValid)
            {
                db.Maaltijd.Add(maaltijd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(maaltijd);
            }
        }
    }
}
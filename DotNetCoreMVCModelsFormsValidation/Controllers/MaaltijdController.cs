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
        //Scaffold-DbContext -Connection "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Maaltijden;Integrated Security=True" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Context MaaltijdContext

        public MaaltijdController()
        {
            db = new MaaltijdContext();
        }

        public ViewResult Index()
        {
            return View(db.Maaltijd.ToList());
        }

        public ViewResult Filter(string keyword)
        {
            return View("Index",db.Maaltijd.FromSql($"Select * from Maaltijd  where Type = {keyword} ").ToList());
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View(new Maaltijd());
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
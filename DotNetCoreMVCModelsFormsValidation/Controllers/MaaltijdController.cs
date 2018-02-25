using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMVCModelsFormsValidation.Models;
using Newtonsoft.Json;

namespace DotNetCoreMVCModelsFormsValidation.Controllers
{
    public class MaaltijdController : Controller
    {
        private List<Maaltijd> maaltijden = new List<Maaltijd>();
        public MaaltijdController()
        {
            maaltijden.Add(
                new Maaltijd
                {
                    Id =1,
                    Type =MaaltijdType.Ontbijt,
                    Naam ="Ontbijt1",
                    Prijs =25
                });
            maaltijden.Add(
                new Maaltijd
                {
                    Id = 10,
                    Type = MaaltijdType.Lunch,
                    Naam = "Dagmenu",
                    Prijs = 35
                });
        }
        public ViewResult Index()
        {
            if (TempData.Peek("maaltijden") != null)
            {
                maaltijden = JsonConvert.DeserializeObject<List<Maaltijd>>(TempData["maaltijden"].ToString());
            }
            return View(maaltijden);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View(new Maaltijd { Type=MaaltijdType.Ontbijt });
        }

        [HttpPost]
        public IActionResult Create(Maaltijd maaltijd)
        {
            if (ModelState.IsValid)
            {
                maaltijden.Add(maaltijd);
                TempData["maaltijden"] = JsonConvert.SerializeObject(maaltijden);
                TempData.Keep();
                //return View("Finish", maaltijd);
                return RedirectToAction("Index");
            }
            else
            {
                return View(maaltijd);
            }
        }
    }
}
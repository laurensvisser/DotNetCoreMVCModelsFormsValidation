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
                return RedirectToAction("Index");
            }
            else
            {
                return View(maaltijd);
            }
        }
    }
}
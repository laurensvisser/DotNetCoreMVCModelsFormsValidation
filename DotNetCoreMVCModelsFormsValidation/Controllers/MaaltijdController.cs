using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreMVCModelsFormsValidation.Models;

namespace DotNetCoreMVCModelsFormsValidation.Controllers
{
    public class MaaltijdController : Controller
    {
        private List<Maaltijd> maaltijden = new List<Maaltijd>();
        public MaaltijdController()
        {
            maaltijden.Add(
                new Maaltijd { Id=1,
                                Type =MaaltijdType.Ontbijt,
                                Naam ="Ontbijt1",
                                Prijs =25,
                                Gang = new List<Gang> {
                                    new Gang{Id=1, Beschrijving="Ontbijt Delux met Champagne", Type=GangType.Hoofdgerecht }
                                }
                });
            maaltijden.Add(
                new Maaltijd
                {
                    Id = 10,
                    Type = MaaltijdType.Lunch,
                    Naam = "Dagmenu",
                    Prijs = 35,
                    Gang = new List<Gang> {
                                    new Gang{Id=102, Beschrijving="Tomatensoep met balletjes", Type=GangType.Voorgerecht },
                                    new Gang{Id=103, Beschrijving="Vol au vent", Type=GangType.Hoofdgerecht },
                                    new Gang{Id=104, Beschrijving="Dame blanche", Type=GangType.Nagerecht }
                                }
                });
        }
        public IActionResult Index()
        {
            return View(maaltijden);
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DotNetCoreMVCModelsFormsValidation.Models
{
    public enum MaaltijdType
    {
        Ontbijt,
        Lunch,
        Avondmaal
    }
    public class Maaltijd
    {
        public int Id { get; set; }      
        public string Naam { get; set; }
        public MaaltijdType Type { get; set; }

        public decimal Prijs { get; set; }

        public List<SelectListItem> TypeList()
        {
            //List<SelectListItem> maaltijdTypes = new List<SelectListItem>();
            //foreach (string type in Enum.GetNames(typeof(MaaltijdType)))
            //{
            //    maaltijdTypes.Add(new SelectListItem() { Text = type, Value = type});
            //}

            List<SelectListItem> maaltijdTypes = new List<SelectListItem>();
            Enum.GetNames(typeof(MaaltijdType))
                .ToList()
                .ForEach(m => maaltijdTypes.Add(new SelectListItem() { Text = m, Value = m }));
            return maaltijdTypes;
        }
    }
}

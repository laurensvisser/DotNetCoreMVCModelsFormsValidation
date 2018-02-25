using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
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
        [Required]
        public int Id { get; set; }

        [Display(Name ="Beschrijving")]
        [Required(ErrorMessage ="Gelieve een beschrijving op te geven")]
        public string Naam { get; set; }

        [Display(Name = "Type maaltijd")]
        public MaaltijdType Type { get; set; }

        [Required]
        [Range(typeof(decimal), "5", "150", ErrorMessage = "Voorzie voor {0} een bedrag tussen {1} en {2}")]
        public decimal Prijs { get; set; }


        public List<SelectListItem> TypeList()
        {
            List<SelectListItem> maaltijdTypes = new List<SelectListItem>();
            foreach (string type in Enum.GetNames(typeof(MaaltijdType)))
            {
                maaltijdTypes.Add(new SelectListItem() { Text = type, Value = type});
            }
            return maaltijdTypes;
        }
    }
}

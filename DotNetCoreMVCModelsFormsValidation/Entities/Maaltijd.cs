using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreMVCModelsFormsValidation.Entities
{
    public partial class Maaltijd
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Type { get; set; }
        public decimal Prijs { get; set; }
    }
}

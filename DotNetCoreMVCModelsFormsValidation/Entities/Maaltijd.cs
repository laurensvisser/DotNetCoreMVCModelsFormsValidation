using System;
using System.Collections.Generic;

namespace DotNetCoreMVCModelsFormsValidation.Entities
{
    public partial class Maaltijd
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Type { get; set; }
        public decimal Prijs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public decimal Price { get; set; }
        public List<Gang> Gang { get; set; }
    }
}

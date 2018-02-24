namespace DotNetCoreMVCModelsFormsValidation.Models
{
    public enum GangType
    {
        Voorgerecht,
        Hoofdgerecht,
        Nagerecht
    }
    public class Gang
    {
        public int Id { get; set; }
        public GangType Type { get; set; }
        public string Beschrijving { get; set; }
    }

    
}
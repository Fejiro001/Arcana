namespace Arcana.Models
{
    // Model for the report, not database
    public class PotionBrewStat
    {
        public string PotionName { get; set; } = "";
        public int BrewCount { get; set; }
    }

    public class IngredientUsageStat
    {
        public string IngredientName { get; set; } = "";
        public int QuantityUsed { get; set; }
        public string Unit { get; set; } = "";
    }

    public class BrewingReport
    {
        public int TotalBrewed { get; set; }
        public int TotalConsumed { get; set; }

        public List<PotionBrewStat> PopularPotions { get; set; }
            = new();

        public List<IngredientUsageStat> IngredientUsage { get; set; }
            = new();
    }
}

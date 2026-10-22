namespace Arcana.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Unit { get; set; } = "units";
        public string Rarity { get; set; } = "Common";
        public bool IsActive { get; set; } = true;

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        public ICollection<IngredientUsage> UsageHistory { get; set; } = new List<IngredientUsage>();
    }
}

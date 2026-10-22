namespace Arcana.Models
{
    public class BrewedPotion
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        public string Name { get; set; } = string.Empty;
        public string Effect { get; set; } = string.Empty;
        public string Element { get; set; } = string.Empty;

        public DateTime BrewedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ConsumedAt { get; set; }

        public string Status { get; set; } = "Available";

        public ICollection<IngredientUsage> IngredientUsages { get; set; } = new List<IngredientUsage>();
    }
}

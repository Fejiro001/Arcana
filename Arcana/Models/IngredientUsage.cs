namespace Arcana.Models
{
    // Records which ingredients were consumed during brewing
    public class IngredientUsage
    {
        public int Id { get; set; }

        public int IngredientIdId { get; set; }
        public Ingredient Ingredient { get; set; } = null!;

        public int BrewedPotionId { get; set; }
        public BrewedPotion BrewedPotion { get; set; } = null!;

        public int QuantityUsed { get; set; }
    }
}

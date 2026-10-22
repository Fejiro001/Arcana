namespace Arcana.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Effect { get; set; } = string.Empty;
        public string Element { get; set; } = string.Empty;
        public int DurationSeconds { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
        public ICollection<BrewedPotion> BrewedPotions { get; set; } = new List<BrewedPotion>();
    }
}

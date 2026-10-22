namespace Arcana.Models
{
    // Connects Recipes with their required Ingredients and quantities
    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } = null!;

        public int QuantityRequired { get; set; }
    }
}

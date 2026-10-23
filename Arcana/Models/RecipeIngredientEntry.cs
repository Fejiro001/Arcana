namespace Arcana.Models
{
    // Model for Ingredients temporarily added to recipe before saving to SQLite
    public class RecipeIngredientEntry
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; } = "";
        public string Unit { get; set; } = "";
        public int QuantityRequired { get; set; }
    }
}

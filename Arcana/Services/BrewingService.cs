using Arcana.Data;
using Arcana.Models;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Services
{
    public class BrewingService
    {
        // Check ingredient availability before brewing.
        public string? GetStockError(int recipeId)
        {
            using var db = new AlchemyContext();

            var recipe = db.Recipes
                .AsNoTracking()
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefault(r => r.Id == recipeId);

            return ValidateStock(recipe);
        }

        // Finish brewing, deducts stock, create potion and record ingredient usage.
        public BrewedPotion CompleteBrew(int recipeId)
        {
            using var db = new AlchemyContext();
            // The transaction ensures that the stock deductions, brewed potion, and ingredient usage records are committed together or rolled back together.
            using var transaction = db.Database.BeginTransaction();

            var recipe = db.Recipes
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefault(r => r.Id == recipeId);

            // Recheck stock immediately before saving.
            string? error = ValidateStock(recipe);

            if (error != null)
                throw new InvalidOperationException(error);

            // Validation guarantees recipe is not null.
            var validRecipe = recipe!;

            DeductIngredients(validRecipe);

            var potion = CreatePotion(validRecipe);

            RecordIngredientUsage(validRecipe, potion);

            db.BrewedPotions.Add(potion);
            db.SaveChanges();

            transaction.Commit();

            return potion;
        }

        private static string? ValidateStock(Recipe? recipe)
        {
            if (recipe == null || !recipe.IsActive)
                return "This recipe is unavailable.";

            if (recipe.RecipeIngredients.Count == 0)
                return "The recipe has no ingredients.";

            foreach (var item in recipe.RecipeIngredients)
            {
                if (!item.Ingredient.IsActive)
                    return $"{item.Ingredient.Name} is retired.";

                if (item.QuantityRequired <= 0)
                    return "Recipe quantities must be positive.";

                if (item.Ingredient.Stock < item.QuantityRequired)
                {
                    return $"Insufficient {item.Ingredient.Name}. " +
                        $"Required: {item.QuantityRequired}, " +
                        $"Available: {item.Ingredient.Stock}.";
                }
            }

            return null;
        }

        private static void DeductIngredients(Recipe recipe)
        {
            foreach (var item in recipe.RecipeIngredients)
            {
                item.Ingredient.Stock -= item.QuantityRequired;
            }
        }

        private static BrewedPotion CreatePotion(Recipe recipe)
        {
            return new BrewedPotion
            {
                RecipeId = recipe.Id,
                Name = recipe.Name,
                Effect = recipe.Effect,
                Element = recipe.Element,
                BrewedAt = DateTime.UtcNow,
                Status = "Available"
            };
        }

        private static void RecordIngredientUsage(
            Recipe recipe, BrewedPotion potion)
        {
            foreach (var item in recipe.RecipeIngredients)
            {
                potion.IngredientUsages.Add(new IngredientUsage
                {
                    IngredientId = item.IngredientId,
                    QuantityUsed = item.QuantityRequired
                });
            }
        }
    }
}

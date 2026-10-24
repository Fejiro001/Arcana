using Arcana.Data;
using Arcana.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Arcana.Repositories
{
    public class DashboardRepository
    {
        public (int Ingredients, int Recipes, int Potions) GetCounts()
        {
            using var db = new AlchemyContext();

            int ingredients = db.Ingredients
                .Count(i => i.IsActive);

            int recipes = db.Recipes
                .Count(r => r.IsActive);

            int potions = db.BrewedPotions
                .Count(p => p.Status == "Available");

            return (ingredients, recipes, potions);
        }

        public List<BrewedPotion> GetRecentBrews()
        {
            using var db = new AlchemyContext();

            return db.BrewedPotions
                .AsNoTracking()
                .OrderByDescending(p => p.BrewedAt)
                .Take(5)
                .ToList();
        }

        // Finds recipes that:
        // - Are active.
        // - Contain at least one ingredient.
        // - Have sufficient quantities of every required ingredient.
        // - Don't depend on retired ingredients.
        // It then recommends the recipe with the shortest brewing duration.
        public Recipe? GetSuggestedRecipe()
        {
            using var db = new AlchemyContext();

            var recipes = db.Recipes
                .AsNoTracking()
                .Where(r => r.IsActive)
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                .ToList();

            return recipes
                .Where(r =>
                    r.RecipeIngredients.Count > 0 &&
                    r.RecipeIngredients.All(ri =>
                        ri.Ingredient.IsActive &&
                        ri.QuantityRequired > 0 &&
                        ri.Ingredient.Stock >= ri.QuantityRequired))
                .OrderBy(r => r.DurationSeconds)
                .ThenBy(r => r.Name)
                .FirstOrDefault();
        }
    }
}

using Arcana.Data;
using Arcana.Models;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Repositories
{
    public class RecipeRepository
    {
        // Get all recipes
        public List<Recipe> GetAll()
        {
            using var db = new AlchemyContext();

            return db.Recipes.AsNoTracking()
                .OrderBy(r => r.Name)
                .ToList();
        }

        // Get a recipe by its id
        public Recipe? GetById(int id)
        {
            using var db = new AlchemyContext();

            return db.Recipes.AsNoTracking()
                .Include(r => r.RecipeIngredients)
                .ThenInclude(ri => ri.Ingredient)
                .FirstOrDefault(r => r.Id == id);
        }

        // Get all active ingredients
        public List<Ingredient> GetAvailableIngredients()
        {
            using var db = new AlchemyContext();

            return db.Ingredients.AsNoTracking()
                .Where(i => i.IsActive)
                .OrderBy(i => i.Name)
                .ToList();
        }

        public void Save(Recipe recipe, List<RecipeIngredientEntry> ingredients)
        {
            using var db = new AlchemyContext();

            ValidateRecipe(db, recipe, ingredients);

            // Add a new recipe
            if (recipe.Id == 0)
            {
                CreateRecipe(db, recipe, ingredients);
            }
            // Update a recipe
            else
            {

            }
        }

        public void CreateRecipe(AlchemyContext db, Recipe recipe, List<RecipeIngredientEntry> ingredients)
        {
            recipe.RecipeIngredients = ingredients.Select(i => new RecipeIngredient
            {
                IngredientId = i.IngredientId,
                QuantityRequired = i.QuantityRequired
            }).ToList();

            db.Recipes.Add(recipe);
        }

        public void UpdateRecipee(AlchemyContext db, Recipe recipe, List<RecipeIngredientEntry> ingredients)
        {
            var existing = db.Recipes
                .Include(r => r.RecipeIngredients)
                .FirstOrDefault(r => r.Id == recipe.Id);

            if (existing == null || !existing.IsActive) throw new InvalidOperationException("Recipe not found or retired.");

            existing.Name = recipe.Name;
            existing.Effect = recipe.Effect;
            existing.Element = recipe.Element;
            existing.DurationSeconds = recipe.DurationSeconds;

            SyncRecipeIngredients(db, existing, ingredients);
        }

        public void Retire(int recipeId)
        {
            using var db = new AlchemyContext();

            var recipe = db.Recipes.Find(recipeId);

            if (recipe == null || !recipe.IsActive) throw new InvalidOperationException("Recipe not found or already retired.");

            recipe.IsActive = false;
            db.SaveChanges();
        }

        // Updating ingredients list
        private void SyncRecipeIngredients(AlchemyContext db, Recipe existingRecipe, List<RecipeIngredientEntry> ingredients)
        {
            var ids = ingredients
                .Select(i => i.IngredientId)
                .ToHashSet();

            // Remove ingredients that are not part of the updated ingredients list.
            foreach (var old in existingRecipe.RecipeIngredients.ToList())
            {
                if (!ids.Contains(old.IngredientId))
                {
                    db.RecipeIngredients.Remove(old);
                }
            }

            // Add new ingredients or update existing quantities.
            foreach (var item in ingredients)
            {
                var current = existingRecipe.RecipeIngredients
                    .FirstOrDefault(ri => ri.IngredientId == item.IngredientId);

                if (current == null)
                {
                    // Create a new RecipeIngredient
                    existingRecipe.RecipeIngredients.Add(
                        new RecipeIngredient
                        {
                            IngredientId = item.IngredientId,
                            QuantityRequired = item.QuantityRequired
                        });
                }
                else
                {
                    // Update quantity required
                    current.QuantityRequired = item.QuantityRequired;
                }
            }
        }

        // Validate the recipe form
        public void ValidateRecipe(AlchemyContext db, Recipe recipe, List<RecipeIngredientEntry> ingredients)
        {
            recipe.Name = recipe.Name.Trim();
            recipe.Effect = recipe.Effect.Trim();
            recipe.Element = recipe.Element.Trim();

            if (string.IsNullOrWhiteSpace(recipe.Name) ||
                string.IsNullOrWhiteSpace(recipe.Effect) ||
                string.IsNullOrWhiteSpace(recipe.Element))
            {
                throw new InvalidOperationException("Complete all recipe details.");
            }

            if (recipe.DurationSeconds <= 0) throw new InvalidOperationException("Brewing duration must be greater than zero.");

            // Validate the ingredients
            ValidateIngredients(db, ingredients);

            // Prevent adding recipes having same name
            bool duplicate = db.Recipes.Any(r =>
            r.Id != recipe.Id &&
            r.Name.ToLower() == recipe.Name.ToLower());

            if (duplicate) throw new InvalidOperationException("A recipe with this name already exists.");
        }

        // Validate the recipe ingredients
        private void ValidateIngredients(AlchemyContext db, List<RecipeIngredientEntry> ingredients)
        {
            if (ingredients.Count == 0) throw new InvalidOperationException("Add at least one ingredient.");

            if (ingredients.Any(i => i.QuantityRequired <= 0)) throw new InvalidOperationException("Ingredient quantities must be positive.");

            // Ensure same ingredient is not added to recipe
            var ingredientIds = ingredients.Select(i => i.IngredientId).ToList();

            if (ingredientIds.Distinct().Count() != ingredientIds.Count) throw new InvalidOperationException("An ingredient cannot appear twice.");

            // Check if ingredients selected are all available
            int available = db.Ingredients.Count(i => ingredientIds.Contains(i.Id) && i.IsActive);

            if (available != ingredientIds.Count) throw new InvalidOperationException("One or  more ingredients are unavailable.");
        }
    }
}

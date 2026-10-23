using Arcana.Data;
using Arcana.Models;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Repositories
{
    public class IngredientRepository
    {
        // Retrieve ingredients, optionally filtering by name.
        public List<Ingredient> GetAll(string search = "")
        {
            // Method-level
            using var context = new AlchemyContext();

            var query = context.Ingredients.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(search))
            {
                string term = search.Trim().ToLower();

                query = query.Where(i =>
                i.Name.ToLower().Contains(term));
            }

            return query.OrderBy(i => i.Name).ToList();
        }

        // Add a new ingredient.
        public void Add(Ingredient ingredient)
        {
            using var context = new AlchemyContext();

            // Validate the ingredient
            ValidateIngredient(ingredient);

            if (context.Ingredients.Any(i => i.Name.ToLower() == ingredient.Name.ToLower()))
            {
                throw new InvalidOperationException("An ingredient with this name already exists.");
            }

            context.Ingredients.Add(ingredient);
            context.SaveChanges();
        }

        // Update existing ingredient.
        public void Update(Ingredient ingredient)
        {
            using var context = new AlchemyContext();

            ValidateIngredient(ingredient);

            var existing = context.Ingredients.Find(ingredient.Id);

            if (existing == null)
            {
                throw new InvalidOperationException("Ingredient not found.");
            }

            if (!existing.IsActive)
            {
                throw new InvalidOperationException("Retired ingredients cannot be edited.");
            }

            bool duplicateName = context.Ingredients.Any(i =>
            i.Id != ingredient.Id && 
            i.Name.ToLower() == ingredient.Name.ToLower());

            if (duplicateName)
            {
                throw new InvalidOperationException("Another ingredient already uses this name.");
            }

            // Prevent the change of ingredient unit that is currently required by an active recipe
            bool usedByActiveRecipe = context.RecipeIngredients.Any(ri => ri.IngredientId == ingredient.Id && ri.Recipe.IsActive);

            if (usedByActiveRecipe && !string.Equals(existing.Unit, ingredient.Unit, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("The unit cannot be changed while this " + "ingredient belongs to an active recipe.");
            }

            existing.Name = ingredient.Name;
            existing.Stock = ingredient.Stock;
            existing.Unit = ingredient.Unit;
            existing.Rarity = ingredient.Rarity;

            context.SaveChanges();
        }

        // Retire an ingredient without deleting historical data.
        public void Retire(int ingredientId)
        {
            using var context = new AlchemyContext();

            var ingredient = context.Ingredients.Find(ingredientId);

            if (ingredient == null)
            {
                throw new InvalidOperationException("Ingredient not found.");
            }

            if (!ingredient.IsActive)
            {
                throw new InvalidOperationException("The ingredient is already retired.");
            }

            bool usedByActiveRecipe = context.RecipeIngredients
                .Any(ri =>
                    ri.IngredientId == ingredient.Id &&
                    ri.Recipe.IsActive);
            if (usedByActiveRecipe)
            {
                throw new InvalidOperationException("This ingredient cannot be retired because " + "it belongs to an active potion recipe.");
            }

            ingredient.IsActive = false;
            context.SaveChanges();
        }

        private static void ValidateIngredient(Ingredient ingredient)
        {
            ingredient.Name = ingredient.Name.Trim();
            ingredient.Unit = ingredient.Unit.Trim();

            if (string.IsNullOrWhiteSpace(ingredient.Name))
            {
                throw new InvalidOperationException("Ingredient name is required.");
            }

            if (string.IsNullOrWhiteSpace(ingredient.Unit))
            {
                throw new InvalidOperationException("Ingredient unit is required.");
            }

            if (ingredient.Stock < 0)
            {
                throw new InvalidOperationException("Ingredient stock cannot be negative.");
            }

            if (!Enum.IsDefined(ingredient.Rarity))
            {
                throw new InvalidOperationException("Select a valid ingredient rarity.");
            }
        }
    }
}

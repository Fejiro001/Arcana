using Arcana.Models;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Data
{
    public class AlchemyContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<BrewedPotion> BrewedPotions { get; set; }
        public DbSet<IngredientUsage> IngredientUsages { get; set; }

        // The default constructor is needed for the designer and migrations
        public AlchemyContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = Path.Combine(
                AppContext.BaseDirectory,
                "arcana.db"
            );

            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ingredients have a unique name
            modelBuilder.Entity<Ingredient>()
                .HasIndex(i => i.Name)
                .IsUnique();

            // Store ingredient rarity as a string
            modelBuilder.Entity<Ingredient>()
                .Property(i => i.Rarity)
                .HasConversion<string>();

            // Recipes have a unique name
            modelBuilder.Entity<Recipe>()
                .HasIndex(r => r.Name)
                .IsUnique();

            // A recipe can contain many ingredients
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Ingredient)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.IngredientId)
                .OnDelete(DeleteBehavior.Restrict);

            // Brewed potions retain their associated recipes
            modelBuilder.Entity<BrewedPotion>()
                .HasOne(p => p.Recipe)
                .WithMany(r => r.BrewedPotions)
                .HasForeignKey(p => p.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Ingredient usage records remain linked to brew history
            modelBuilder.Entity<IngredientUsage>()
                .HasOne(u => u.Ingredient)
                .WithMany(i => i.UsageHistory)
                .HasForeignKey(u => u.IngredientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IngredientUsage>()
                .HasOne(u => u.BrewedPotion)
                .WithMany(i => i.IngredientUsages)
                .HasForeignKey(u => u.BrewedPotionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed Database
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 1,
                    Name = "Moonwater",
                    Stock = 15,
                    Unit = "drops",
                    Rarity = IngredientRarity.Common
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Phoenix Feather",
                    Stock = 9,
                    Unit = "feathers",
                    Rarity = IngredientRarity.Rare
                },
                new Ingredient
                {
                    Id = 3,
                    Name = "Unicorn Hair",
                    Stock = 6,
                    Unit = "strands",
                    Rarity = IngredientRarity.Epic
                },
                new Ingredient
                {
                    Id = 4,
                    Name = "Mandrake Root",
                    Stock = 10,
                    Unit = "roots",
                    Rarity = IngredientRarity.Common
                },
                new Ingredient
                {
                    Id = 5,
                    Name = "Stardust",
                    Stock = 12,
                    Unit = "pinches",
                    Rarity = IngredientRarity.Rare
                },
                new Ingredient
                {
                    Id = 6,
                    Name = "Dragon Scale",
                    Stock = 8,
                    Unit = "scales",
                    Rarity = IngredientRarity.Legendary
                }
            );

            // Potion recipes
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = 1,
                    Name = "Crimson Vitality",
                    Effect = "Restores vitality",
                    Element = "Fire",
                    DurationSeconds = 8
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Mystic Clarity",
                    Effect = "Enhances focus",
                    Element = "Water",
                    DurationSeconds = 12
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Phantom Veil",
                    Effect = "Grants temporary invisibility",
                    Element = "Shadow",
                    DurationSeconds = 10
                }
            );

            // Ingredients required for each recipe
            modelBuilder.Entity<RecipeIngredient>().HasData(
                new { RecipeId = 1, IngredientId = 4, QuantityRequired = 2 },
                new { RecipeId = 1, IngredientId = 2, QuantityRequired = 1 },
                new { RecipeId = 2, IngredientId = 1, QuantityRequired = 2 },
                new { RecipeId = 2, IngredientId = 5, QuantityRequired = 3 },
                new { RecipeId = 3, IngredientId = 3, QuantityRequired = 1 },
                new { RecipeId = 3, IngredientId = 5, QuantityRequired = 2 },
                new { RecipeId = 3, IngredientId = 6, QuantityRequired = 1 }
            );
        }
    }
}

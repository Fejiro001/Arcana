using Arcana.Data;
using Arcana.Models;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Repositories
{
    public class ReportRepository
    {
        public BrewingReport GetReport(DateTime startUtc, DateTime endUtcExclusive)
        {
            using var db = new AlchemyContext();

            var brews = db.BrewedPotions
                .AsNoTracking()
                .Where(p => p.BrewedAt >= startUtc &&
                            p.BrewedAt < endUtcExclusive);

            return new BrewingReport
            {
                TotalBrewed = brews.Count(),
                TotalConsumed = brews.Count(p => p.ConsumedAt != null),
                PopularPotions = GetPopularPotions(brews),
                IngredientUsage = GetIngredientUsage(db, startUtc, endUtcExclusive)
            };
        }

        private static List<PotionBrewStat> GetPopularPotions(IQueryable<BrewedPotion> brews)
        {
            return brews
                .GroupBy(p => p.Name)
                .Select(g => new PotionBrewStat
                {
                    PotionName = g.Key,
                    BrewCount = g.Count()
                })
                .OrderByDescending(p => p.BrewCount)
                .ThenBy(p => p.PotionName)
                .ToList();
        }

        private static List<IngredientUsageStat> GetIngredientUsage(AlchemyContext db, DateTime startUtc, DateTime endUtcExclusive)
        {
            return db.IngredientUsages
                .AsNoTracking()
                .Where(u =>
                    u.BrewedPotion.BrewedAt >= startUtc &&
                    u.BrewedPotion.BrewedAt < endUtcExclusive)
                .GroupBy(u => new
                {
                    u.IngredientId,
                    u.Ingredient.Name,
                    u.Ingredient.Unit
                })
                .Select(g => new IngredientUsageStat
                {
                    IngredientName = g.Key.Name,
                    Unit = g.Key.Unit,
                    QuantityUsed = g.Sum(u => u.QuantityUsed)
                })
                .OrderByDescending(i => i.QuantityUsed)
                .ThenBy(i => i.IngredientName)
                .ToList();
        }
    }
}

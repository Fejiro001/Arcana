
using Arcana.Data;
using Arcana.Models;
using Microsoft.EntityFrameworkCore;

namespace Arcana.Repositories
{
    public class PotionRepository
    {
        public List<BrewedPotion> GetAll()
        {
            using var db = new AlchemyContext();

            return db.BrewedPotions
                .AsNoTracking()
                .Where(p => p.Status != "Deleted")
                .OrderByDescending(p => p.BrewedAt)
                .ToList();
        }

        public void Consume(int potionId)
        {
            using var db = new AlchemyContext();

            var potion = db.BrewedPotions.Find(potionId);

            if (potion == null)
                throw new InvalidOperationException(
                    "Potion not found.");

            if (potion.Status != "Available")
                throw new InvalidOperationException(
                    "This potion is no longer available.");

            potion.Status = "Consumed";
            potion.ConsumedAt = DateTime.UtcNow;

            db.SaveChanges();
        }

        // Soft deletion
        public void Delete(int potionId)
        {
            using var db = new AlchemyContext();

            var potion = db.BrewedPotions.Find(potionId);

            if (potion == null)
                throw new InvalidOperationException(
                    "Potion not found.");

            if (potion.Status == "Deleted")
                throw new InvalidOperationException(
                    "This potion has already been deleted.");

            potion.Status = "Deleted";

            db.SaveChanges();
        }
    }
}

using labb2.Data;
using labb2.Domain;
using Microsoft.EntityFrameworkCore;

namespace labb2.Services
{
    public class GameService
    {
        public async Task<List<Game>> GetAllAsync()
        {
            using var db = new AppDbContext();
            return await db.Games.ToListAsync();
        }

        public async Task AddAsync(Game game)
        {
            using var db = new AppDbContext();
            db.Games.Add(game);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Game game)
        {
            using var db = new AppDbContext();
            db.Games.Remove(game);
            await db.SaveChangesAsync();
        }
    }
}

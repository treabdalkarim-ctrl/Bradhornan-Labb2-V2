using labb2.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
namespace labb2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BradhornanDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, Name = "Anna Andersson", Email = "anna@mail.com", IsActive = true, JoinedDate = DateTime.Now.AddYears(-1) }
            );

            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Title = "Catan", Category = "Strategi", MinPlayers = 3, MaxPlayers = 4, PlayTimeMinutes = 90 }
            );

            modelBuilder.Entity<Event>().HasData(
                new Event { Id = 1, Title = "Strategikväll", Date = DateTime.Now.AddDays(7), Location = "Föreningslokalen", MaxParticipants = 10 }
            );
        }
    }
}
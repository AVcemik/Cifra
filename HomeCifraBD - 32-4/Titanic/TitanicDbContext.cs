using Microsoft.EntityFrameworkCore;

namespace Titanic
{
    public class TitanicDbContext : DbContext
    {
        public DbSet<Passenger> Passengers => Set<Passenger>();

        public TitanicDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = TitanicPassengers.db");
        }
    }
}

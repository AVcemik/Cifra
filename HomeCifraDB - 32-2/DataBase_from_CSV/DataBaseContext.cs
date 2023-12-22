using Microsoft.EntityFrameworkCore;

namespace DataBase_from_CSV
{
    internal class DataBaseContext : DbContext
    {
        public DbSet<Iris> Irises => Set<Iris>();

        public DataBaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = IrisesDatabase.db");
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace HomeCifraWPF___88.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<People> Peopls => Set<People>();
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = People.db");
        }
    }
}

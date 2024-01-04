using Microsoft.EntityFrameworkCore;

namespace InternetShop
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}


using Microsoft.EntityFrameworkCore;

namespace HomeCifraBD___34_3
{
    public class HomeWorkContext : DbContext
    {
        public HomeWorkContext(DbContextOptions<HomeWorkContext> options)  : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; } = null!;
    }
}

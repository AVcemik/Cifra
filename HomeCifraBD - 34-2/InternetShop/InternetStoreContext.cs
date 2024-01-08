using Microsoft.EntityFrameworkCore;
using InternetShop.Entity;

namespace InternetShop
{
    public enum SettingBD
    {
        serverBD,
        userBD,
        passwordBD,
        databaseBD,
        error
    }
    public partial class InternetStoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!; 
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public InternetStoreContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var vers = new Version(6, 0, 2);
            var MySql = new MySqlServerVersion(vers);

            string serverBD = InternetShop.StringConnection(SettingBD.serverBD);
            string userBD = InternetShop.StringConnection(SettingBD.userBD);
            string passwordBD = InternetShop.StringConnection(SettingBD.passwordBD);
            string databaseBD = InternetShop.StringConnection(SettingBD.databaseBD);

            string Connect = $"server={serverBD};user={userBD};password={passwordBD};database={databaseBD};";
            optionsBuilder.UseMySql(Connect, MySql);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeCifraBD___34_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("connectionString.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionBuilder = new DbContextOptionsBuilder<HomeWorkContext>();
            var version = new MySqlServerVersion(new Version(8, 0, 25));
            var options = optionBuilder.UseMySql(connectionString, version).Options;

            using (HomeWorkContext db = new HomeWorkContext(options))
            {
                List<User> listUser = db.Users.ToList();
                foreach (User item in listUser)
                {
                    Console.WriteLine($"Id: {item.Id} - Имя: {item.Name} - Возраст: {item.Age}");
                }
            }
        }
    }
}
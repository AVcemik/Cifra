using InternetShop.Entity;

namespace InternetShop
{
    internal class InternetShop
    {
        //-----------------------------------------------------
        // Здесь подставляем свои данные базы данных
        public static string serverBD = "192.168.40.78";        // IP адрес сервера базы данных
        public static string userBD = "Online-Shop-Admin";      // Имя пользователя базы данных
        public static string passwordBD = "0000";               // Пароль пользователя базы данных
        public static string databaseBD = "OnlineShop";         // Имя базы данных
        //-----------------------------------------------------
        static void Main(string[] args)
        {
            List<Category> categories = new()
            {
                new("Еда", "Съедобное"),
                new("Инструменты", "Есть не советую")
            };

            List<Product> listProducts = new()
            {
                new Product("Яблоко", "Вкусное и немного зеленое", 15, categories[1-1]),
                new Product("Молоток", "Увеличивает пальцы и окрашивает в красный цвет", 500, categories[2-1]),
                new Product("Банан", "Желтый, не бумеранг", 86, categories[1-1]),
                new Product("Мухомор", "Красный в пятнышку, окуратно но есть можно", 10, categories[1-1]),
                new Product("Наковальня", "На нее можно положить яблоко и ударить молотком", 2499, categories[2-1])
            };

            List<Product> listProductOne = new()
            {
                listProducts[2-1], listProducts[3-1], listProducts[4-1], listProducts[5-1]
            };
            List<Product> listProductTwo = new()
            {
                listProducts[1-1], listProducts[3-1], listProducts[4-1]
            };


            User cemik = new("cemik", "Cifra39", "aveal.cemik@gmail.com");
            User basenka = new("basenka", "Cifra39", "basenka@gmail.com");

            Order orderOne = new(DateTime.Now, Statuse.В_процессе, cemik, listProductOne);
            Order orderTwo = new(DateTime.Now, Statuse.Создан, basenka, listProductTwo);

            cemik.Orders!.Add(orderOne);
            basenka.Orders!.Add(orderTwo);

            using (InternetStoreContext context = new())
            {
                context.Categories.AddRange(categories);
                context.Products.AddRange(listProducts);
                context.Add(cemik);
                context.Add(basenka);
                context.Orders.Add(orderOne);
                context.Orders.Add(orderTwo);

                context.SaveChanges();
            }
        }
        public static string StringConnection(SettingBD context)
        {
            switch (context)
            {
                case SettingBD.serverBD: return serverBD;
                case SettingBD.userBD: return userBD;
                case SettingBD.passwordBD: return passwordBD;
                case SettingBD.databaseBD: return databaseBD;
                default:
                    {
                        Console.WriteLine("Неверное выполнен метод stringConnection в InternetShop.cs");
                        return "Error";
                    }
            }            
        }
    }
}
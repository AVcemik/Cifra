using InternetShop.Entity;

namespace InternetShop
{
    internal class InternetShop
    {
        //-----------------------------------------------------
        // Здесь подставляем свои данные базы данных
        public static string serverBD = "192.168.40.78";          // IP адрес сервера базы данных
        public static string userBD = "Online-Shop-Admin";        // Имя пользователя базы данных
        public static string passwordBD = "0000";                 // Пароль пользователя базы данных
        public static string databaseBD = "OnlineShop";           // Имя базы данных
        //-----------------------------------------------------
        static void Main(string[] args)
        {

            Category food = new("Еда", "Съедобное");
            Category tools = new("Инструменты", "Есть не советую");

            List<Product> listProductOne = new()
            {
                new Product("Яблоко", "Вкусное и немного зеленое", 15, food),
                new Product("Молоток", "Увеличивает пальцы и окрашивает в красный цвет", 500, tools),
                new Product("Банан", "Желтый, не бумеранг", 86, food),
                new Product("Мухомор", "Красный в пятнышку, окуратно но есть можно", 10, food),
                new Product("Наковальня", "На нее можно положить яблоко и ударить молотком", 2499, tools),
            };
            List<Product> listProductTwo = new()
            {
                new Product("Яблоко", "Вкусное и немного зеленое", 15, food),
                new Product("Молоток", "Увеличивает пальцы и окрашивает в красный цвет", 500, tools)
            };

            User cemik = new("cemik", "Cifra39", "aveal.cemik@gmail.com", new List<Order>());
            User basenka = new("basenka", "Cifra39", "basenka@gmail.com", new List<Order>());

            Order orderOne = new(DateTime.Now, Statuse.InProcessen, cemik, listProductOne);
            Order orderTwo = new(DateTime.Now, Statuse.Created, basenka, listProductTwo);

            cemik.Orders!.Add(orderOne);
            basenka.Orders!.Add(orderTwo);

            using (InternetStoreContext context = new())
            {
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
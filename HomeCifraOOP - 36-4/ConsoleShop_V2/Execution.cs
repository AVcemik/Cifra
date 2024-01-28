namespace ConsoleShop_V2
{
    public static class Execution
    {
        private static User? _user;
        private static List<Product> _products = Extension.ListProduct();
        
        /// <summary>
        /// Работа приложения
        /// </summary>
        public static void ExecutionProgram()
        {
            while (true)
            {
                Console.Clear();
                _user!.DisplayUserInfo();
                DisplayListProduct();
                BuyProduct();

                Console.WriteLine("\n\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        public static void EnterUserAndMoney()  // Ввод данных пользоваателя
        {
            Console.Clear();
            Console.Write($"Введите ваше имя: ");
            string? name = Console.ReadLine();
            Console.Write($"Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine()!);
            Console.Write("Введите кол-во ваших денег: ");
            decimal money = decimal.Parse(Console.ReadLine()!);
            money *= LuckeMan();

            Console.WriteLine("\n\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();


            _user = new User(name, age, money);
        }
        public static void BuyProduct() // Процесс покупки товара
        {
            Console.Write("Введите номер товара: ");
            int numberProduct = int.Parse(Console.ReadLine()!);
            CheckExitProgram(numberProduct);
            Console.Write("Введите кол-во: ");
            int countProduct = int.Parse(Console.ReadLine()!);

            decimal tempPrice = _products[numberProduct - 1].GetPrice(_user!);
            _user!.Spent += _products[numberProduct-1].GetPrice(_user) * countProduct;
            _user.Money -= _products[numberProduct-1].GetPrice(_user) * countProduct;

            string? logTransaction = $"Пользователь: {_user.Name} | Название товара: {_products[numberProduct-1].Name} | Кол-во: {countProduct} | Цена: {tempPrice}";
            FileManagement.FileSave(logTransaction);

            Console.WriteLine("Приобретенный товар:");
            Console.WriteLine(logTransaction);
        }
        public static void DisplayListProduct() // Информация о прудктах
        {
            int count = 1;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("0 | Выход из программы");
            Console.Write("│\n");            
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var item in _products)
            {
                Console.Write($"{count} | ");
                item.DisplayProductInfo(_user!);
                count++;
            }
        }
        public static int LuckeMan()    // Множитель счета пользователя
        {
            Console.Write("Введите число от 1 до 3: ");
            int luckyNumber = int.Parse(Console.ReadLine()!);

            if (new Random().Next(3) == luckyNumber)
            {
                Console.WriteLine("Вы счастливый человек, ваш баланс увеличился в 3 раза!! :)");
                return 3;
            }
            else
            {
                Console.WriteLine("Сегодня вам не повезло :(");
                return 1;
            }    
        }
        public static void CheckExitProgram(int exit)   // Проверка выхода из программы
        {
            if (exit == 0)
                Environment.Exit(0);
        }
    }
}

namespace ConsoleShop_V2
{
    public class User
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Money { get; set; }
        public float Discount
        {
            get
            {
                if (Spent >= 50000)
                    return 0.1f;
                else if (Spent >= 10000)
                    return 0.05f;

                return 0;
            }
        }
        public decimal Spent { get; set; } = 0;

        public User(string? name, int age, decimal money)
        {
            Name = name;
            Age = age;
            Money = money;
        }

        public void DisplayUserInfo()   // Информация пользователя
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Пользователь: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Денег на счете: {Money}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Денег потратил: {Spent}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

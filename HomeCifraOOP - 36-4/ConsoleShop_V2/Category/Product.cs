namespace ConsoleShop_V2
{
    public enum Socket
    {
        AM5,
        AM4,
        LGA1700,
        LGA1200,
        LGA1151,
        LGA1150
    }
    public class Product
    {
        public string? Name { get; set; }
        public decimal Price { private get; set; }
        public string? Description { get; set; }
        public string? Manufacture { get; set; }

        protected Product(string? name, decimal price, string? description, string? manufacture)
        {
            Name = name;
            Price = price;
            Description = description;
            Manufacture = manufacture;
        }
        public virtual float GetDiscount(User user) // Получение скидки товара
        {
            float discount = 0;
            if (HoliDay())
                discount += 0.2f;
            return 1 - user.Discount - discount;
        }
        public decimal GetPrice(User user) // Получение цены 
        {
            return Price * (decimal)GetDiscount(user);
        }
        public virtual void DisplayProductInfo(User user)   // Информация о товаре
        {
            Console.WriteLine($"Название: {Description} - Цена: {GetPrice(user):F2} - Скидка: {(1 - GetDiscount(user)) * 100:F2}%");
        }
        public virtual void DisplayProductInfo(User user, int[] cursor)   // Информация о товаре с красивым выводом
        {
            int topPosition = Console.GetCursorPosition().Top;
            Console.SetCursorPosition(4, topPosition);
            Console.Write($"│ Название: {Description} ");
            Console.SetCursorPosition(cursor[0], topPosition);
            Console.Write($" │ Цена: {GetPrice(user):F2} ");
            Console.SetCursorPosition(cursor[1], topPosition);
            Console.Write($" │ Скидка: {(1 - GetDiscount(user)) * 100:F2}%");
            Console.SetCursorPosition(cursor[2] + 3, topPosition);
            Console.Write($" │ \n");
        }
        public bool HoliDay()   // Проверка на праздники
        {
            List<DateTime> listHoliDay = new()
            {
                new DateTime(DateTime.Now.Year, 1, 7),
                new DateTime(DateTime.Now.Year, 2, 14),
                new DateTime(DateTime.Now.Year, 3, 8),
                new DateTime(DateTime.Now.Year, 4, 25),
                new DateTime(DateTime.Now.Year, 5, 9),
                new DateTime(DateTime.Now.Year, 6, 15),
                new DateTime(DateTime.Now.Year, 7, 30),
                new DateTime(DateTime.Now.Year, 8, 9),
                new DateTime(DateTime.Now.Year, 9, 1),
                new DateTime(DateTime.Now.Year, 10, 31),
                new DateTime(DateTime.Now.Year, 11, 29),
                new DateTime(DateTime.Now.Year, 12, 31),
            };
            foreach (DateTime holiDay in listHoliDay)
            {
                if (DateTime.Now.Date == holiDay.Date)
                    return true;
            }
            return false;
        }
    }
}

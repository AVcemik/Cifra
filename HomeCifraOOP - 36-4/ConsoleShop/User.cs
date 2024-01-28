namespace ConsoleShop
{
    public class User
    {
        public string? Name { get; set; }
        public decimal Money { get; set; }

        public User(string? name, decimal money)
        {
            Name = name;
            Money = money;
        }
    }
}

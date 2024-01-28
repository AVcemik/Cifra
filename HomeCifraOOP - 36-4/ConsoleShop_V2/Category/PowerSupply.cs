namespace ConsoleShop_V2
{
    public class PowerSupply : Product
    {
        public int Power { get; set; }

        public PowerSupply(string? name, decimal price, string? description, string? manufacture, int power) : base(name, price, description, manufacture)
        {
            Power = power;
        }

        public override float GetDiscount(User user) // Получение скидки товара с  учетом пользователя
        {
            return 0.5f; 
        }
    }
}

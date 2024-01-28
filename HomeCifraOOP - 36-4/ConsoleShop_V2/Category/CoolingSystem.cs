namespace ConsoleShop_V2
{
    public class CoolingSystem : Product
    {
        public double MaximumAirFlow { get; set; }
        public CoolingSystem(string? name, decimal price, string? description, string? manufacture, double maximumAirFlow) : base(name, price, description, manufacture)
        {
            MaximumAirFlow = maximumAirFlow;
        }
        public override float GetDiscount(User user) // Получение скидки товара с учетом пользователя
        {
            float discount = base.GetDiscount(user);

            if (user.Age > 30)
                discount -= 0.25f;

            return discount;
        }       
    }
}

namespace ConsoleShop.Category
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
    public class Motherbord : IProduct
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Manufacture { get; set; }
        public Socket Socket { get; set; }

        public Motherbord(string? name, decimal price, string? description, string? manufacture, Socket socket)
        {
            Name = name;
            Price = price;
            Description = description;
            Manufacture = manufacture;
            Socket = socket;
        }
    }
}

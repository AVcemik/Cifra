namespace ConsoleShop.Category
{
    public class Processor : IProduct
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Manufacture { get; set; }
        public double Frequency { get; set; }
        public int Core { get; set; }
        public Socket Socket { get; set; }

        public Processor(string? name, decimal price, string? description, string? manufacture, double frequency, int core, Socket socket)
        {
            Name = name;
            Price = price;
            Description = description;
            Manufacture = manufacture;
            Frequency = frequency;
            Core = core;
            Socket = socket;
        }
    }
}

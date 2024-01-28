namespace ConsoleShop.Category
{
    public class Videocard : IProduct
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Manufacture { get; set; }
        public double Frequency { get; set; }
        public int MemorySize { get; set; }

        public Videocard(string? name, decimal price, string? description, string? manufacture, double frequency, int memorySize)
        {
            Name = name;
            Price = price;
            Description = description;
            Manufacture = manufacture;
            Frequency = frequency;
            MemorySize = memorySize;
        }
    }
}

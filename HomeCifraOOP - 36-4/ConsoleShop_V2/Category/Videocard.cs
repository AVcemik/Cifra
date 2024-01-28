namespace ConsoleShop_V2
{
    public class Videocard : Product
    {
        public double Frequency { get; set; }
        public int MemorySize { get; set; }

        public Videocard(string? name, decimal price, string? description, string? manufacture, double frequency, int memorySize) : base (name, price, description, manufacture)
        {
            Frequency = frequency;
            MemorySize = memorySize;
        }
    }
}

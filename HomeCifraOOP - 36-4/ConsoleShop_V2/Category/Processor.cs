namespace ConsoleShop_V2
{
    public class Processor : Product
    {
        public double Frequency { get; set; }
        public int Core { get; set; }
        public Socket Socket { get; set; }

        public Processor(string? name, decimal price, string? description, string? manufacture, double frequency, int core, Socket socket) : base (name, price, description, manufacture)
        {
            Frequency = frequency;
            Core = core;
            Socket = socket;
        }
    }
}

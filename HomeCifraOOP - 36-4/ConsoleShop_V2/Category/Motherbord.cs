namespace ConsoleShop_V2
{
    
    public class Motherbord : Product
    {
        public Socket Socket { get; set; }

        public Motherbord(string? name, decimal price, string? description, string? manufacture, Socket socket) : base(name, price, description, manufacture)
        {
            Socket = socket;
        }
    }
}

namespace ConsoleShop_V2
{
    public class Housing : Product
    {
        public int Long { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Housing(string? name, decimal price, string? description, string? manufacture, int longHousing, int width, int height) : base(name, price, description, manufacture)
        {
            Long = longHousing;
            Width = width;
            Height = height;
        }
    }
}

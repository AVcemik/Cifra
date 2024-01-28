namespace ConsoleShop.Category
{
    public interface IProduct
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Manufacture { get; set; }
    }
}

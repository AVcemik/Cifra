
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Entity
{
    public class Product
    {
        [Key]
        [Column("Product_id")]
        public int Product_Id { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "DECIMAL")]
        public decimal Price { get; set; }
        [ForeignKey("Category_id")]
        public Category? Categorys {get; set;}
        public Product() { }

        public Product(string? name, string? description, decimal price, Category? category)
        {
            Name = name;
            Description = description;
            Price = price;
            Categorys = category;
        }
    }
}



using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Entity
{
    public enum Statuse
    {
        Created,
        InProcessen,
        Ready
    }
    public class Order
    {
        [Key]
        [Column("Order_id")]
        public int Id { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Date { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public Statuse Status { get; set; }
        [ForeignKey("User_id")]
        public User? User { get; set; }
        [ForeignKey("Product_id")]
        public List<Product>? Products { get; set; }
        public Order() { }

        public Order(DateTime date, Statuse status, User? user, List<Product>? products)
        {
            Date = date;
            Status = status;
            User = user;
            Products = products;
        }
    }
}

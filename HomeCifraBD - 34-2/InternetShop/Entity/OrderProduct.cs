

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Entity
{
    public class OrderProduct
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("Order")]
        public Order Order { get; set; }

        [Key]
        public int ProductId { get; set; }
        [ForeignKey("Product")]
        public Product Product { get; set; }
        public OrderProduct() { }

    }
}

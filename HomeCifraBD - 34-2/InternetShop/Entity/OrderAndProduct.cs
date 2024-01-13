

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Entity
{
    public class OrderAndProduct
    {
        [Key]
        [Column("Order_id")]
        public int Oreder_Id { get; set; }
        [Key]
        [Column("Product_id")]
        public int Product_Id { get; set; }
    }
}

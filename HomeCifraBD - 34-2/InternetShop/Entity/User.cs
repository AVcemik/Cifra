

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Entity
{
    public class User
    {
        [Key]
        [Column("User_id")]
        public int Id { get; set; }
        [Column(TypeName ="VARCHAR(25)")]
        public string? UserName { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string? Password { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public string? Email { get; set; }
        [ForeignKey("Order_id")]
        public List<Order>? Orders { get; set; }
        public User() { }

        public User(string? userName, string? password, string? email)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Orders = new();
        }
    }
}

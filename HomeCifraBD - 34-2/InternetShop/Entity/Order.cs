﻿

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Entity
{
    public enum Statuse
    {
        Создан,
        В_процессе,
        Готов
    }
    public class Order
    {
        [Key]
        [Column("Order_id")]
        public int Order_Id { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime Date { get; set; }
        [Column(TypeName = "VARCHAR(25)")]
        public Statuse Status { get; set; }
        [ForeignKey("User_id")]
        public User? User { get; set; }
        [ForeignKey("Product_id")]
        [InverseProperty("Order")]
        public List<OrderProduct> OrderProducts { get; set; }
        //public List<Product>? Products { get; set; }
        public Order() { }

        public Order(DateTime date, Statuse status, User? user /*List<OrderProduct>? products*/)
        {
            Date = date;
            Status = status;
            User = user;
            //Products = products;
            //OrderProducts = products;
        }
    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShop.Entity
{
    public class Category
    {

        [Key]
        [Column("Category_id")]
        public int Category_Id { get; set; }
        [Column(TypeName ="VARCHAR(25)")]
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Category() { }

        public Category(string? name, string? description)
        {
            Name = name;
            Description = description;
        }
    }
}

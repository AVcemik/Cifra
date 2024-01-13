using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeCifraBD___34_3
{
    public class User
    {
        [Key]
        [Column("User_Id")]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public User(string? name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace HomeCifraWPF___88
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public People()
        {
        }

        public People(string? firstName, string? lasrName, int age)
        {
            FirstName = firstName;
            LastName = lasrName;
            Age = age;
        }
    }
}

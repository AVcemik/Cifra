using CsvHelper.Configuration.Attributes;
using System.ComponentModel;


namespace CsvReaders
{
    internal class Person
    {
        [Name("Имя")]
        [DisplayName("Имя")]
        public string FirstName { get; set; }
        [Name("Фамилия")]
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [Name("Email")]
        [DisplayName("Электроный адрес")]
        public string Email { get; set; }
        [Name("Номер телефона")]
        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}

using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

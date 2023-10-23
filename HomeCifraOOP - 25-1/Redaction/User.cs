using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redaction
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }

        public User(string username, string firstName, string secondName, string email, string password, DateTime birthDate)
        {
            Username = username;
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
        }
        
    }
}

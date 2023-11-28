using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaskManager
{
    enum Roles
    {
        Admin,
        User
    }
    internal class User
    {
        private int _userId;
        private string _userName;
        private string _password;
        private Roles _role;
        private List<Task> _tasks;

        public User(int userId, string userName, string password, Roles role)
        {
            _userId = userId;
            _userName = userName;
            _password = password;
            _role = role;
        }

        public void login(string userName, string userPassword)
        {
            if (_userName == userName && _password == userPassword)
            {
                Console.WriteLine("Вы вошли в систему");
            }
            else
            {
                Console.WriteLine("пользователь не найден или пароль введен не верно");
            }

        }
        public void Logout()
        {
            Console.WriteLine("Вы вышли из системы");
        }
        public string GetUserName()
        {
            return _userName;
        }
    }
}

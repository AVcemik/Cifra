using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount
{
    internal class User
    {
        private uint _id;
        private string _login;
        private string _password;
        public string Name { get; private set; }
        public ushort Age {  get; private set; }
        private bool IsAdmin;
        private User (bool  id)
        {
            Id
        }
        private User(uint id, string login, string password, string name, ushort age)
        {
            _id = id;
            _login = login;
            _password = password;
            Name = name;
            Age = age;
        }
        public static uint NextId(List<User>)
        {

        }
        public static User Registration(uint id)
        {
            Console.Clear();
            Console.Write("Введите ваше Логин: ");
            string login = Console.ReadLine()!;
            Console.Write("Введите ваш пароль: ");
            string password = Console.ReadLine()!;
            Console.Write("Введите ваше Имя: ");
            string name = Console.ReadLine()!;
            Console.Write("Введите ваш возраст: ");
            ushort age = 0;
            ushort.TryParse(Console.ReadLine()!, out age);
            if (age == 0)
            {
                Other.DisplayTextRed("Возраст введен не корректно!!!");
                return new User()
            }
                
        }
        public static uint SetId(List<User> users)
        {
            uint count = 1;
            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < users.Count; j++)
                {
                    if (users[j].Id == count)
                    {
                        count++;
                        break;
                    }
                }
            }
            return 0;
        }
    }
}

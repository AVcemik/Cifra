using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SofT_industries
{
    internal class User : IUser
    {
        private static string _pathData = Directory.GetCurrentDirectory() + "\\userData.txt";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string name, string login, string password)
        {
            string[] userData = File.ReadAllLines(_pathData);

            for (int i = 0; i < userData.Length; i++)
            {
                if (userData[i].Split(" ")[2] == login)
                {
                    Console.WriteLine("Такой пользователь уже существует");
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    return;
                }
            }

            Id = userData.Length + 1;
            Name = new IsDataExists((name) => { if (name == null) { throw new Exception("Не заполено имя"); } return name; })(name);
            Login = new IsDataExists((login) => { if (login == null) { throw new Exception("Не заполено имя"); } return login; })(login);
            Password = new IsDataExists((password) => { if (password == null) { throw new Exception("Не заполено имя"); } return password; })(password);
            SaveData($"{Id} {Name} {Login} {Password}");
        }

        private void SaveData(string newUser)
        {
            string[] temp = File.ReadAllLines(_pathData);
            string[] dataUser = new string[temp.Length + 1];
            for (int i = 0; i < temp.Length; i++)
            {
                dataUser[i] = temp[i];
            }
            dataUser[dataUser.Length - 1] = newUser;

            File.WriteAllLines(_pathData, dataUser);

        }
        public static string GetPath()
        {
            return _pathData;
        }
        public delegate string IsDataExists(string data);


        //При создании объекта класса User, проверять, что пользователь с
        //указанным логином не существует в системе.
        //Если существует, выводить сообщение о том, что пользователь с таким
        //логином уже существует, и завершать создание объекта.
        //Идентификатор пользователя (Id) должен присваиваться автоматически на
        //основе количества существующих пользователей.
        //Данные о пользователе должны быть сохранены в файле userData.txt в
        //формате: "Id Name Login Password".
        //Реализовать метод SaveData, который будет сохранять данные
        //пользователя в файле userData.txt, расположенный в корневой папке
        //проекта
    }
}

using UserAccount;
using System.Xml;
using System.Xml.Serialization;

internal class Program
{
    private static readonly string _pathFile = Directory.GetCurrentDirectory() + "\\Data.xml";
    public static List<User> users = new();
    private static void Main(string[] args)
    {
        PresetStartApp();
        StartMenu();
    }
    public static void StartMenu()          // Старотовое меню
    {
        Console.Clear();
        Console.WriteLine("Меню");
        Console.WriteLine("1 - Войти");
        Console.WriteLine("2 - Зарегестрироваться");
        Console.WriteLine("0 - Выход");
        Console.Write("Выберите номер меню: ");
        string command = Console.ReadLine()!;

        if (command == "1")
            LoginMenu();
        else if (command == "2")
            RegistrationUserMenu();
        else if (command == "0")
            Other.ExitApp();
        else
        {
            Console.WriteLine("Упсс... что то пошло не так, разработчики уже разбираются...");
            Other.ExitApp();
        }
    }
    public static void LoginMenu()          // Меню авторизации
    {
        Console.Clear();
        Console.WriteLine("Войдите в систему");
        Console.Write("Введите логин: ");
        string login = Console.ReadLine()!;
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine()!;

        for (int i = 0; i < users.Count; i++)
        {
            if (CheckLoginAndPassword(login, password))
            {
                if (users[i].IsAdmin == false)
                    UserMenu();
                else if (users[i].IsAdmin == true)
                    AdminMenu();
            }
            else
            {
                Other.DisplayTextRed("Неверное введены данные!!!");
                Other.PausedApp();
            }
        }
    }
    public static void UserMenu()           // Меню пользователя
    {
        Console.Clear();
        Console.WriteLine("Вы вошли как пользователь");
        Console.WriteLine("1 - Выйти из аккаунта");
        Console.WriteLine("0 - Выйти из приложения");
        Console.Write("Выберите номер меню: ");
        string command = Console.ReadLine()!;

        if (command == "1")
            StartMenu();
        else if (command == "0")
            Other.ExitApp();
        else
        {
            Console.WriteLine("Упсс... что то пошло не так, разработчики уже разбираются...");
            Other.ExitApp();
        }
    }
    public static void AdminMenu()          // Меню администратора
    {
        Console.Clear();
        Console.WriteLine("Вы вошли как администратор");
        Console.WriteLine("1 - Выйти из аккаунта");
        Console.WriteLine("0 - Выйти из приложения");
        Console.Write("Выберите номер меню: ");
        string command = Console.ReadLine()!;

        if (command == "1")
            StartMenu();
        else if (command == "0")
            Other.ExitApp();
        else
        {
            Console.WriteLine("Упсс... что то пошло не так, разработчики уже разбираются...");
            Other.ExitApp();
        }
    }
    public static void RegistrationUserMenu()   // Процесс регистрации
    {
        uint nextId = SetMaxId();
        nextId++;

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
        if (age > 0)
        {
            bool checkUser = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Login == login)
                {
                    Other.DisplayTextRed("Пользователь с таким логин уже существует!!!");
                    Other.PausedApp();
                    checkUser = true;
                    break;
                }
            }
            if (checkUser == false)
            {
                users.Add(Registration(nextId, login, password, name, age));
                UpdateListUsers();
                Other.DisplayTextGreen("Регистрация прошла успешно!!!");
                Other.PausedApp();
                StartMenu();
            }
            else
                StartMenu();
        }
        else
        {
            Other.DisplayTextRed("Возраст введен не корректно!!!");
            Other.PausedApp();
            StartMenu();
        }
    }
    public static uint SetMaxId()           // Определяем следующий Id
    {
        uint[] ids = new uint[users.Count];
        for (int i = 0; i < users.Count; i++)
        {
            ids[i] = users[i].Id;
        }
        return ids.Max();
    }
    public static void UpdateListUsers()     // Настройки програмы перед запуском
    {
        SerializationXML();
        DeserializationXML();
    }
    public static void SerializationXML()   // Сериализация файла
    {
        XmlSerializer serializer = new(typeof(List<User>));
        File.Delete(_pathFile);
        using (StreamWriter streamWriter = new(_pathFile))
        {
            serializer.Serialize(streamWriter, users);
        }
    }
    public static void DeserializationXML() // Десериализация
    {
        XmlSerializer serializer = new(typeof(List<User>));

        using (StreamReader streamReader = new(_pathFile))
        {
            users.Clear();
            users = (List<User>)serializer.Deserialize(streamReader)!;
        }
    }
    public static void PresetStartApp() // Стартовые настройки программы
    {
        if (!File.Exists(_pathFile))
        {
            users.Add(new User() { Id = 0, Login = "admin", Password = "admin", Name = "admin", Age = 36, IsAdmin = true});
            users.Add(new User() { Id = 1, Login = "user", Password = "user", Name = "user", Age = 36, IsAdmin = false});
            SerializationXML();
        }
        else
        {
            try
            {
                DeserializationXML();
            }
            catch (Exception)
            {
                Console.WriteLine("Data файл был поврежден, программа восстановлен к заводским установкам");
                File.Delete(_pathFile);
                users.Add(new User() { Id = 0, Login = "admin", Password = "admin", Name = "admin", Age = 36, IsAdmin = true });
                users.Add(new User() { Id = 1, Login = "user", Password = "user", Name = "user", Age = 36, IsAdmin = false });
                SerializationXML();
            }
            finally
            {
                DeserializationXML();
            }
        }
    }
    public static User Registration(uint id, string login, string password, string name, ushort age) // Регистрация нового пользователя
    {
        return new User() { Id = id, Login = login, Password = password, Name = name, Age = age, IsAdmin = false};
    }
    public static bool CheckLoginAndPassword(string login, string password) // Проверка данных аутентификации
    {
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Login == login && users[i].Password == password)
                return true;
        }
        return false;
    }
}
namespace RaskManager
{
    internal class TaskManagerApp
    {
        static void Main(string[] args)
        {
            User user = new(1, "Lubenets", "secret", Roles.User);
            User admin = new(0, "cemik", "verysecret", Roles.Admin);

            user.login("Lubenets", "secret");

            Task learnCSharp = new(1, "Выучить с#", "Выучить язык программирования", Status.InProcess, Priority.Hight, new DateTime(2024, 3, 30), user.GetUserName());

            user.Logout();
        }
    }
}
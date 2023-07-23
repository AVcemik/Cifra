// Программирование на C#
// Данный методический материал рассчитан на 4 уроков
// Урок 4/4

// Напишите программу, которая позволяет пользователю удалить
// файл или папку. Программа должна запрашивать путь к файлу
// или папке, которую нужно удалить, и выполнить удаление. Перед
// удалением, программа должна запрашивать подтверждение пользователя.

string path;

Console.WriteLine("Введите полнуй путь к папке или файлу для ее удаления");
path = Console.ReadLine()!;

DirectoryInfo dirInfo = new DirectoryInfo(path);
FileInfo fileInfo = new FileInfo(path);
if (dirInfo.Exists)
{
    Console.WriteLine($"Вы точно хотите уделить папку {path = dirInfo.Name}");
    string command = Console.ReadLine()!;
    if (command.ToLower() == "да" || command.ToLower() == "yes" || command.ToLower() == "д" || command.ToLower() == "y")
    {
        dirInfo.Delete();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Папка успешно удален.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
if (File.Exists(path))
{
    Console.WriteLine($"Вы точно хотите уделить файл {path = fileInfo.Name}");
    string command = Console.ReadLine()!;
    if (command.ToLower() == "да" || command.ToLower() == "yes" || command.ToLower() == "д" || command.ToLower() == "y")
    {
        fileInfo.Delete();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Файл успешно удален.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Папка или файл не найдены");
    Console.ForegroundColor = ConsoleColor.White;
}

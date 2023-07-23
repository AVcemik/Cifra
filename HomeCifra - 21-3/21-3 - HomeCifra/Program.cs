// Программирование на C#
// Данный методический материал рассчитан на 4 урока
// Урок 3/4
// Тема 21. Работа с файловой системой. Домашнее
// задание. Для двух уроков

// Напишите программу, которая позволяет пользователю перемещаться по
// файловой системе компьютера.
// На экране должна быть видна текущая директория пользователя и под
// этим выводом ожидаться название папки, в которую необходимо перейти.
// После ввода, пользователь переходит в эту папку
// Пример: 
// Укажем целевой директорией - папку newFile:
// После ввода переходим в папку newFile:

string path = Environment.CurrentDirectory;

while (true)
{
    Console.WriteLine("Введите .. для перехода в предыдущий каталог");
    Console.WriteLine("Введите Exit для выхода");
    Console.WriteLine("Введите название папки для перехода");
    Console.WriteLine();
    Console.Write(path + "> ");
    string command = Console.ReadLine()!;
    Console.Clear();

    switch (command.ToLower())
    {
        case "exit": Environment.Exit(0); break;
        case "..":
            {
                DirectoryInfo curDir = new DirectoryInfo(path);
                if (curDir.Parent != null)
                {
                    DirectoryInfo? newDir = curDir.Parent;
                    path = newDir!.FullName;
                }
                else BadCatalog();
            }
            break;
        default:
            {
                DirectoryInfo curDir = new DirectoryInfo($@"{path}\{command}");
                if (curDir.Exists) path = curDir.FullName;
                else BadCatalog();
            }
            break;
    }
}

void BadCatalog()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Такого каталога не существует");
    Console.ForegroundColor= ConsoleColor.White;
    Console.WriteLine();
}
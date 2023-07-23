using System;
using System.IO;

namespace TextDocument
{
    class _2_Work
    {
        static void Main(string[] args)
        {
            string dirPath = @"C:\Docs";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            string filePath = Path.Combine(dirPath, "document.txt");
            Console.WriteLine("Введите команду (чтение/запись): ");
            string command = Console.ReadLine();
            if (command.Trim().ToLower() == "чтение")
            {
                ReadFile(filePath);
            }
            else if (command.Trim().ToLower() == "запись")
            {
                WriteFile(filePath);
            }
            else
            {
                Console.WriteLine("Неверная команда");
            }
        }

        static void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.Clear();
                string text = File.ReadAllText(filePath);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Файл не существует");
            }
        }

        static void WriteFile(string filePath)
        {
            Console.WriteLine("Введите заголовок: ");
            string title = Console.ReadLine();
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string content = $"{date}\n | \n{title}\n | \n{text}";
            File.WriteAllText(filePath, content);
        }
    }
}
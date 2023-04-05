using System;
using System.IO;

namespace ConsoleApp
{
    class _3_Work
    {
        static void Main(string[] args)
        {
            // Путь к файлу
            string path = @"C:\Docs\file.txt";

            // Команда пользователя
            string command = Console.ReadLine();

            // Выполнение команды
            switch (command)
            {
                case "чт": // чтение файла
                    ReadFile(path);
                    break;
                case "зп": // запись в файл
                    WriteFile(path);
                    break;
                default: // неверная команда
                    Console.WriteLine("Неверная команда");
                    break;
            }
        }

        // Метод для чтения файла
        static void ReadFile(string path)
        {
            try
            {
                // Открытие файла для чтения
                using (StreamReader sr = new StreamReader(path))
                {
                    // Очистка консоли
                    Console.Clear();

                    // Чтение и вывод содержимого файла
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (Exception e)
            {
                // Обработка исключений
                Console.WriteLine("Ошибка при чтении файла: " + e.Message);
            }
        }

        // Метод для записи в файл
        static void WriteFile(string path)
        {
            try
            {
                // Считывание заголовка и текста от пользователя
                Console.WriteLine("Введите заголовок:");
                string title = Console.ReadLine();
                Console.WriteLine("Введите текст:");
                string text = Console.ReadLine();

                // Форматирование данных для записи в файл
                string data = DateTime.Now.ToString() + "\n\n" + title + "\n\n" + text;

                // Открытие файла для записи (если файл не существует, он будет создан)
                using (StreamWriter sw = new StreamWriter(path))
                {
                    // Запись данных в файл
                    sw.Write(data);
                }
            }
            catch (Exception e)
            {
                // Обработка исключений
                Console.WriteLine("Ошибка при записи в файл: " + e.Message);
            }
        }
    }
}
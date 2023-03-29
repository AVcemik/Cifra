namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            string _directory = "";
            string _fileName = "Data.txt";
            string _fullPath = "";
            List<string> _data = new List<string>();

            _data = ReadFile();

            while (true)
            {
                Console.Clear();
                PrintData();
                string line = Console.ReadLine();
                string lineDigital = "";
                foreach(char i in line)
                {
                    if (Char.IsDigit(i))
                    {
                        lineDigital += i;
                    }
                }
                if (line == "Exit" || line == "exit")
                {
                    break;
                }
                if (line == "Help" || line == "help" || line == "?")
                {
                    PrintHelp();
                    continue;
                }
                if (line == "remove " + lineDigital || line == "Remove " + lineDigital)
                {
                    int lineInt = int.Parse(lineDigital);
                    if (lineInt > _data.Count)
                    {
                        BadRemoveLine();
                        continue;
                    }
                    _data.RemoveAt(lineInt - 1);
                    continue;
                }
                AppendData(line);
            }
            WriteDataToFile();

            void AppendData(string data)
            {
                _data.Add(data);
            }
            List<String> ReadFile()
            {
                _directory = Directory.GetCurrentDirectory();
                _directory = new DirectoryInfo(_directory).Parent.Parent.Parent.FullName; // Parent на папку выше переводит FullName получить полный путь
                _fullPath = Path.Combine(_directory, _fileName); // Path.Combine стваит сам слэш между путями Комбинировать путь
                return File.ReadAllLines(_fullPath).ToList(); // Чтение файла и запись в string переменную
            }
            void PrintData()
            {
                int lineCount = 2;
                for (int i =0; i < _data.Count; i++)
                {
                    Console.WriteLine("{0}: {1}", i +1, _data[i]);
                }
                Console.WriteLine("----------------------");
            }
            void PrintHelp()
            {
                Console.Clear();
                Console.WriteLine("Список команд:");
                Console.WriteLine();
                Console.WriteLine("Help - Вызов справки");
                Console.WriteLine("Remove - Удаляет строку (нужно указать номер строки) {Пример: Remove 3}");
                Console.WriteLine("Exit - Завершение программы");
                Console.WriteLine("\nНажмите любую клавишу для продожения...");
                Console.ReadKey();
            }
            void BadRemoveLine()
            {
                Console.Clear();
                Console.WriteLine("Вы ввели неверный номер строки, \n\nНажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
            void WriteDataToFile()
            {
                File.WriteAllLines(_fullPath, _data); // Запись string-данных в файл по пути
                Console.WriteLine("Файл сохранен");
            }
        }
    }
}
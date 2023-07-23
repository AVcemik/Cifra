using System;
using System.IO;

namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
                //File.WriteAllText(_fullPath, ""); создать заранее
                //File.Create(_fileName);
            string _directory = "c:\\Docs";
            string _fileName = "Data.txt";
            string _fullPath = "";
            _fullPath = Path.Combine( _directory, _fileName );
            List<string> _content = new List<string>();

            CheckDir(_directory);


            switch (RunCommand())
            {
                case Command.write:
                    WriteFile(_fullPath);
                    break;

                case Command.read:
                    ReadFile(_fullPath);
                    break;
            }


            void CheckDir(string directory)
            {
                if (!Directory.Exists("c:\\Docs"))
                {
                    Directory.CreateDirectory(directory);
                }
            }
            string RunCommand()
            {
                Console.Write("Введите комманду (запись/чтение): ");
                string command = Console.ReadLine();
                return command.ToLower().Trim();
            }
            void WriteFile(string fullPath)
            {
                List<string> content = File.ReadAllLines(fullPath).ToList();

                Console.Write("Введите Заголовок: ");
                string title = Console.ReadLine().ToUpper();

                Console.Write("Введите текст: ");
                string text = Console.ReadLine();

                string time = DateTime.Now.ToString();
                content.Add(title + " | " + text + " | " + time);

                File.WriteAllLines(_fullPath, content);
            }
            string[] ReadFile(string fullPath)
            {
                Console.WriteLine("");
                string[] text = File.ReadAllLines(fullPath);
                for (int i = 0; i < text.Length; i++)
                {
                    Console.WriteLine(text[i]);
                }
                return text;
            }

            void ExitProgramm()
            {
                Console.WriteLine("Нажмите любую клавишу для завершения...");
                Console.ReadKey();
                Environment.Exit(0);
            }

        }
    }
}

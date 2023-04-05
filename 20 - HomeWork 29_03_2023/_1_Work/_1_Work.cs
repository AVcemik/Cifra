using System.Data.Common;
using System.Diagnostics.SymbolStore;

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
                PrintData(_data);
                string _line = Console.ReadLine();


                if (ExecuteCommand(_line) == true) continue;
                AppendData(_line);
            }

            //----------------------------------------

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
            void WriteDataToFile()
            {
                File.WriteAllLines(_fullPath, _data); // Запись string-данных в файл по пути
                Console.WriteLine("");
                Console.WriteLine("Файл сохранен");
            }
            int CheckDigital(string lineDigital)
            {
                string result = "";
                int resultInt;
                foreach (char i in lineDigital)
                {
                    if (Char.IsDigit(i))
                    {
                        result += i;
                    }
                }
                if (result == "") return -1;
                else resultInt = int.Parse(result); return resultInt - 1;
            }
            byte CheckChar(string cheackChar)
            {
                string result = "";
                char resultChar = ' ';

                if (cheackChar.Length == 1) return 1;

                else
                {
                    Console.WriteLine("Вы ввели не символ!!!");
                    ContinueProgramm();
                }
                return 0;
            }
            bool CheckBadLine(List<string> data, int numLine)
            {
                if (numLine > data.Count || numLine <= 0) 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Вы ввели неверный номер строки");
                    ContinueProgramm();
                    return true;
                }
                return false;
            }
            void PrintData(List<string> data)
            {
                int lineCount = 2;
                for (int i = 0; i < data.Count; i++)
                {
                    Console.WriteLine("{0}: {1}", i +1, data[i]);
                }
                Console.WriteLine("----------------------");
            }

            bool ExecuteCommand(string line)
            {
                bool result;
                int lineDigitalInt = CheckDigital(line);
                int lineInt = lineDigitalInt + 1;
                line = line.ToLower().Trim();

                string[] commands = new[] { Const.exit, Const.save, Const.help, Const.help2, Const.numline, Const.numberline, Const.lenghtline + lineInt, 
                                            Const.numchar + lineInt, Const.editnumchar, Const.editline + lineInt, Const.calcline, Const.remove + lineInt, ""};

                if (line == Const.exit) ExitProgramm();
                else if (line == Const.save) SaveProgramm();
                else if (line == Const.help || line.ToLower().Trim() == Const.help2) PrintHelp();
                else if (line == Const.numline) NumLine(_data);
                else if (line == Const.numberline) NumberLine(_data);
                else if (line == Const.lenghtline + lineInt) LenghtLine(_data, lineDigitalInt);
                else if (line == Const.numchar + lineInt) NumChar(_data, lineDigitalInt);
                else if (line == Const.editnumchar) EditNumChar(_data);
                else if (line == Const.editline + lineInt) EditLine(_data, lineDigitalInt);
                else if (line == Const.calcline) SumLine(_data);
                else if (line == Const.remove + lineInt) RemoveLine(_data, lineDigitalInt);
                else if (line == "") ;
                else return false;

                return commands.Contains(line);
            }

            void ExitProgramm()
            {
                WriteDataToFile();
                Console.WriteLine("Нажмите любую клавишу для завершения...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            void PrintHelp()
            {
                Console.Clear();
                Help.CommandHelp();
                ContinueProgramm();
            }
            void SaveProgramm()
            {
                WriteDataToFile();
                ContinueProgramm();
            }
            void NumLine(List<string> data)
            {
                Console.WriteLine("\nКол-во строк: " + data.Count);
                ContinueProgramm() ;
            }
            void NumberLine(List<string> data)
            {
                int numLine = data.Count;
                int result = 0;

                for (int i = 0; i < data.Count; i++)
                {
                    foreach (char s in data[i])
                    {
                        if (char.IsDigit(s))
                        {
                            result += 1;
                            break;
                        }
                    }
                }
                Console.WriteLine("Кол-во строк с цифрами: " + result);
                ContinueProgramm();
            }
            void LenghtLine(List<string> data, int numLine)
            {
                int result = 0;
                if (numLine > data.Count) BadRemoveLine();
                else
                {
                    foreach (var i in data[numLine])
                    {
                        result++;
                    }
                }
                Console.WriteLine("\nКол-во символов в строке: " + result);
                ContinueProgramm();
            }
            void NumChar(List<string> data, int numLine)
            {
                if (CheckBadLine(data, numLine + 1) != true)
                {
                    Console.WriteLine("");

                    for (int i = 0, j = 1; i < data[numLine].Length; i++, j++)
                    {
                        Console.WriteLine(j + "-" + data[numLine][i]);
                    }
                    ContinueProgramm();
                }
            }
            void EditNumChar(List<string> data)
            {
                int numLine;
                int numChar;
                Console.Write("\nВведите номер редактируемой строк: ");
                string strLine = Console.ReadLine();
                if (CheckDigital(strLine) == 0)
                {
                    Console.WriteLine("Такой строки нет!!!");
                    ContinueProgramm();
                }
                else
                {
                    numLine = CheckDigital(strLine);
                    Console.Write("Введите номер символа: ");
                    string strChar = Console.ReadLine();
                    if (CheckDigital(strChar) == 0)
                    {
                        Console.WriteLine("Такого номера символа нет!!!");
                        ContinueProgramm();
                    }
                    else
                    {
                        numChar = CheckDigital(strChar);
                        Console.Write("Введите новый символ: ");
                        string newStrChar = Console.ReadLine();
                        byte boolChar = CheckChar(newStrChar);
                        char newChar = char.Parse(newStrChar);
                        
                        
                        if (boolChar == 1)
                        {
                            string oldData = data[numLine];
                            string newDataLine = "";

                            for (int i = 0; i < oldData.Length; i++)
                            {
                                if (i != numChar)
                                {
                                    char oldChar = oldData[i];
                                    newDataLine += oldChar;
                                }
                                else
                                {
                                    newDataLine += newChar;
                                }
                            }
                            data[numLine] = newDataLine;
                        }
                        else
                        {
                            Console.WriteLine("Обратитеь в службу поддержки");
                            ContinueProgramm();
                        }

                    }
                }

                
            }
            void EditLine(List<string> data, int numLine)
            {
                if (numLine > data.Count || numLine < 0) BadRemoveLine();
                else
                {
                    Console.Write("Введите новую строку: ");
                    string result = Console.ReadLine();
                    data[numLine] = result;
                }
            }
            void SumLine(List<string> data)
            {
                string line;
                char op = ' ';
                int line1;
                int value1;
                int line2;
                int value2;
                int result = 0;

                Console.WriteLine("\nКалькулятор между строк: ");
                Console.WriteLine();

                Console.Write("Введите номер строки: ");
                line = Console.ReadLine();
                line1 = CheckDigital(line);

                Console.Write("Введите оператор (+ - * /): ");
                line = Console.ReadLine();
                if (line == "+" || line == "-" || line == "*" || line == "/")
                {
                    op = char.Parse(line);
                }
                else { Console.WriteLine("Вы ввели неверный оператор"); ContinueProgramm(); }

                Console.Write("Введите номер строки: ");
                line = Console.ReadLine();
                line2 = CheckDigital(line);

                value1 = CheckDigital(data[line1]) + 1;
                value2 = CheckDigital(data[line2]) + 1;

                if (op == '-') result = value1 - value2;
                if (op == '+') result = value1 + value2;
                if (op == '*') result = value1 * value2;
                if (op == '/') result = value1 / value2;

                data.Add("Результат: " + result + " (Строка " + (line1 + 1) + " | Значение = " + value1 + " | Строка " + (line2 + 1) + " | Значение = " + value2);
            }
            void RemoveLine(List<string> data, int numLine)
            {
                if (CheckBadLine(data, numLine + 1) != true) data.RemoveAt(numLine);
            }

            void BadRemoveLine()
            {

                Console.Clear();
                Console.WriteLine("Вы ввели неверный номер строки \n\nНажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
            void ContinueProgramm()
            {
                Console.WriteLine("\nНажмите любую клавишу для продожения...");
                Console.ReadKey();
            }
        }
    }
}
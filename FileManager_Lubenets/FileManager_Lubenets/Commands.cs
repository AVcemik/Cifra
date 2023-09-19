using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager_Lubenets
{
    internal class Commands
    {
        private static string[] _splittedCommand;

        public static string[] SplittedCommand
        {
            get
            {
                return _splittedCommand;
            }
            set
            {
                _splittedCommand = value;
            }
        }


        public static void CommandParser(StringBuilder command)
        {
            SplittedCommand = command.ToString().ToLower().Split(' ');

            switch (SplittedCommand[0]) 
            {
                case "cd":
                    ChangeDirectory();
                    break;

                case "ls":

                    break;

                case "mkdir":
                        MakeDirectory();
                    break;

                case "touch":
                    TouchFile();
                    break;

                case "rm":
                    Remove();
                    break;
                case "rmdir":
                    Remove();
                    break;
                case "exit":
                    Exit();
                    break;
            }
            AdditionalFunctional.UpdateConsole();
        }

        public static void ChangeDirectory()
        {
            if (SplittedCommand.Length > 1)
            {
                string tempDirectory = SplittedCommand[1];
                for (int i = 2; i < SplittedCommand.Length; i++)
                {
                    tempDirectory += " " + SplittedCommand[i];
                }

                if (SplittedCommand[1] == ".." && AdditionalFunctional.CurrentDirectory.Length > 3)
                {
                    AdditionalFunctional.CurrentDirectory = Directory.GetParent(AdditionalFunctional.CurrentDirectory)!.ToString();
                }
                else
                {
                    if (SplittedCommand[1].Contains(@":\") && Directory.Exists(tempDirectory))
                    {
                        AdditionalFunctional.CurrentDirectory = tempDirectory;
                    }
                    else if (Directory.Exists(AdditionalFunctional.CurrentDirectory + @"\" + SplittedCommand[1]))
                    {
                        AdditionalFunctional.CurrentDirectory += @"\" + SplittedCommand[1];
                    }
                    else
                    {
                        Display.DisplayWindowTwo("Такой папки не существует!", false);
                    }
                }
            }
            else
            {
                AdditionalFunctional.CurrentDirectory = AdditionalFunctional.DefaultPath;
            }
            
        }
        public static void MakeDirectory()
        {
            if (SplittedCommand.Length > 1)
            {
                if (Directory.Exists(AdditionalFunctional.CurrentDirectory + "\\" + SplittedCommand[1]))
                {
                    Display.DisplayWindowTwo("Такая папка уже существует", false);
                }
                else
                {
                    Directory.CreateDirectory(AdditionalFunctional.CurrentDirectory + "\\" + SplittedCommand[1]);
                }
            }
            else
            {
                Display.DisplayWindowTwo("Вы не указали название папки", false);
            }
        }
        public static void TouchFile()
        {
            if (SplittedCommand.Length > 1)
            {
                if (File.Exists(AdditionalFunctional.CurrentDirectory + "\\" + SplittedCommand[1] + ".txt"))
                {
                    Display.DisplayWindowTwo("Такой файл уже существует", false);
                }
                else
                {
                    File.Create(AdditionalFunctional.CurrentDirectory + "\\" + SplittedCommand[1] + ".txt");
                }
            }
            else
            {
                Display.DisplayWindowTwo("Вы не указали название файла", false);
            }
        }
        public static void Remove()
        {
            if (SplittedCommand.Length > 1)
            {
                if (SplittedCommand[1] == "-r" && Directory.Exists(AdditionalFunctional.CurrentDirectory + "\\" + SplittedCommand[2]))
                {

                }
            }
        }
        public static void RemoveAll(string path)
        {
            //Directory[] directoryAll = Directory.GetDirectories(path);
        }
        public static void Exit()
        {
            AdditionalFunctional.SetCursorPosition(0, 33);
            Environment.Exit(0);
        }
    }
}

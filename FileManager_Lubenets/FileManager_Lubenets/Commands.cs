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
                    {
                        ChangeDirectory();
                    }
                    break;
                case "exit":
                    {
                        Exit();
                    }
                    break;
            }
            AdditionalFunctional.UpdateConsole();
        }

        public static void ChangeDirectory()
        {
            string tempDirectory = SplittedCommand[1];
            for (int i = 2; i < SplittedCommand.Length; i++)
            {
                tempDirectory += " " + SplittedCommand[i];
            }

            if (SplittedCommand[1] == ".." && AdditionalFunctional.CurrentDirectory.Length >3)
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
                    Display.DisplayWindowTwo("Такого пути не существует!", true);
                }
            }
        }
        public static void Exit()
        {
            AdditionalFunctional.SetCursorPosition(0, 33);
            Environment.Exit(0);
        }
    }
}

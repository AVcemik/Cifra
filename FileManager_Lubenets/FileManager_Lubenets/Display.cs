using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager_Lubenets
{
    internal class Display
    {

        public static void DisplayWindowOne()
        {
            AdditionalFunctional.SetCursorPosition(0, 0);
            Draw.DrawWindow(0, 18);
        }

        public static void DisplayWindowTwo() 
        {
            AdditionalFunctional.SetCursorPosition(20, 0);
            Draw.DrawWindow(20,8);
        }
        public static void DisplayWindowTwo(string text, bool error)
        {
            AdditionalFunctional.SetCursorPosition(20, 0);
            Draw.DrawWindow(20, 8);

            if (error)
            {
                AdditionalFunctional.SetCursorPosition((AdditionalFunctional.WindowWidth / 2) - (text.Length / 2), 25);
                AdditionalFunctional.RedTextConsole(text);
            }
        }

        /// <summary>
        /// Реализация 3-его окна
        /// </summary>
        public static void DisplayWindowThree()
        {
            StringBuilder command = new StringBuilder();

            char key;
            int left = 0;
            int top = 0;

            AdditionalFunctional.GetCurrentCursorPosition(ref left, ref top);

            do
            {
                int currentLeft = 0;
                int currentTop = 0;
                AdditionalFunctional.GetCurrentCursorPosition(ref currentLeft, ref currentTop);
                key = Console.ReadKey().KeyChar;

                if ((ConsoleKey)key == ConsoleKey.Backspace && Console.CursorLeft < left)
                {
                    Console.Write(">");
                }
                else if ((ConsoleKey)key == ConsoleKey.Backspace)
                {
                    command.Remove(command.Length - 1, 1);
                    Console.Write(" ");
                    AdditionalFunctional.SetCursorPosition(currentLeft - 1, currentTop);
                }
                else if (currentLeft == AdditionalFunctional.WindowWidth - 2)
                {
                    AdditionalFunctional.SetCursorPosition(currentLeft, currentTop);
                    Console.Write(" ");
                    AdditionalFunctional.SetCursorPosition(currentLeft, currentTop);
                }
                else
                {
                    command.Append(key);
                }

            } while ((ConsoleKey)key != ConsoleKey.Enter);
            command.Remove(command.Length - 1, 1);

            if (command.ToString() == "cd..")
            {
                command.Clear();
                command.Append("cd ..");
            }

            Commands.CommandParser(command);
        }
    }
}

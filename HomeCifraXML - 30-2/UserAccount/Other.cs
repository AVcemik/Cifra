using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount
{
    public static class Other
    {
        public static void DisplayTextRed(string word)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(word);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void DisplayTextGreen(string word)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(word);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

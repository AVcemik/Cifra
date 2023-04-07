using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1_Work
{
    public static class Operation
   {
        public const char sum = '+';
        public const char difference= '-';
        public const char multiply= '*';
        public const char divide = '/';

        public static void StringListOperators(ref string line)
        {
            foreach (char i in line) 
            { 
                switch (i)
                {
                    case sum:
                        line = line.Replace("" + Operation.sum, " " + Operation.sum + " ");
                        break;
                    case difference:
                        line = line.Replace("" + Operation.difference, " " + Operation.difference + " ");
                        break;
                    case multiply:
                        line = line.Replace("" + Operation.multiply, " " + Operation.multiply + " ");
                        break;
                    case divide:
                        line = line.Replace("" + Operation.divide, " " + Operation.divide + " ");
                        break;
                }
            }
        }
        public static void CheckOperators(string line, ref bool success)
        {
            char result = ' ';
            try
            {
                result = Char.Parse(line);
            }
            catch
            {
                success = false;
            }
        }
    }
}

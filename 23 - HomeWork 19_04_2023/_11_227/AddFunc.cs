using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_227
{
    public class AddFunc
    {

        static public void FillMass(double[,] fallout, out int snow, out int rain)
        {
            Random r = new Random();
            snow = 0;
            rain = 0;

            for (int i = 0; i < fallout.GetLength(0); i++)
            {
                for (int j = 0; j < fallout.GetLength(1); j++)
                {
                    if (j == 0) fallout[i, j] = i + 1;
                    else if (j == 1) fallout[i, j] = r.NextDouble() + r.Next(0, 10);
                    else fallout[i, j] = r.NextDouble() + r.Next(-10, 10);
                }

                if (fallout[i, 2] <= 0) snow += Convert.ToInt32(fallout[i, 1]);
                else rain += Convert.ToInt32(fallout[i, 2]);
            }
        }

        static public void OutputMass(double[,] fallout)
        {


            Console.WriteLine("День\tОсадки\tТемпература");
            for (int i = 0; i < fallout.GetLength(0); i++)
            {
                for (int j = 0; j < fallout.GetLength(1); j++)
                {
                    if (j == 0 && i < 10-1) Console.Write($" {fallout[i, j]:F0}\t");
                    else if (j == 0) Console.Write($" {fallout[i, j]:F0}\t");
                    else if (j == 1) Console.Write(($"  {fallout[i, j]:F0}\t"));
                    else
                    {
                        if (fallout[i,j] >=0) Console.Write($"  {fallout[i, j]:F1}\t");
                        else Console.Write($" {fallout[i, j]:F1}\t");
                    }
                }

                Console.WriteLine($"");
            }
        }
        static public void Exit()
        {
            Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

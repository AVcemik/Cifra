using System;
using System.IO;
using System.Text;

namespace Olymp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] line = Console.ReadLine().Split(' ');

            string[] bugsBox = line[0].Split(' ');


            string[] quantity = new string[int.Parse(bugsBox[1])];
            string[] price = new string[int.Parse(bugsBox[1])];

            quantity = line[1].Split(" ");
            price = line[2].Split(" ");
            int result = -1;

            for (int i = 0; i < quantity.Length; i++)
            {
                int count = 0;
                int tempQuantity = int.Parse(quantity[i]);
                int tempPrice = int.Parse(price[i]);
                for (int j = i + 1; j < quantity.Length; j++)
                {
                    if (j == i) continue;

                    tempQuantity += int.Parse(quantity[j]);
                    tempPrice += int.Parse(price[j]);

                    if (tempQuantity >= int.Parse(bugsBox[0]))
                    {
                        count++;
                        j = count;
                        if (result == -1)
                        {
                            result = tempPrice;
                        }
                        else if (tempPrice == 0) continue;
                        else if (result > tempPrice)
                        {
                            result = tempPrice;
                        }

                        tempQuantity = int.Parse(quantity[i]);
                        tempPrice = int.Parse(price[i]);
                        count = j;
                    }
                    
                }
            }
            Console.WriteLine(result);
        }
    }
}

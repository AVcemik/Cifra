namespace Asynchron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial(5);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Секунда " + i);
                Thread.Sleep(1000);
            }
        }
        public static async void Factorial(int number)
        {
            int result = 1;
            await Task.Run(() =>
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                    Task.Delay(250).Wait();
                }
            });
            
            Console.WriteLine($"\t\t\tФакториал числа {number} = {result}");
        }
    }
}
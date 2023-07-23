using System.Xml.Schema;

namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            // Повторить материал по методичке, используя сочетание не “Hello 
            // World”, а “Добиться успеха легко, познать смысл - вот проблема”

            string firstWorld = "Добиться успеха легко";
            string secondWorld = "познать смысл";
            string thirdWorld = "вот проблема";

            string result = firstWorld + ", " + secondWorld;
            result = string.Concat(result, " -");
            result = $"{result} {thirdWorld}";

            Console.WriteLine(result);

        }
    }
}
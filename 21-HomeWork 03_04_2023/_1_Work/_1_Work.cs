using System;
using System.IO;

namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            string _directory = "c:\\Docs";
            string _fileName = "Data.txt";
            string _fullPath = "";
            List<string> _data = new List<string>();


            _fullPath = Path.Combine( _directory, _fileName );
            if (Directory.Exists("c:\\Docs") != true)
            {
                Directory.CreateDirectory(_directory);
                File.Create(_fileName);
            }
            else if (Directory.Exists("c:\\Docs\\data.txt") != true)
            {
                File.Create(_fileName);
            }
            else

            Console.ReadKey();

        }
    }
}

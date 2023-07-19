using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string name, string author, int year)
        {
            Name=name;
            Author=author;
            Year=year;
        }
        public Book()
        {
            this.Name = "";
            this.Author = "";
            this.Year = 0;
        }
    }
}

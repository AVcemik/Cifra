using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Work_2
{
    internal class HomeLibery
    {
        private List<Book> books;
        public HomeLibery() 
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(string name)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == name)
                {
                    books.RemoveAt(i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Книга удалена");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (i == books.Count-1) Console.WriteLine("Книга не найдена");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public void SearchByName(string name) 
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == name)
                {
                    Console.WriteLine($"{books[i].Name}, {books[i].Author}, {books[i].Year}");
                }
                if (i == books.Count-1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Книга не найдена");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        public void SearchByAuthor(string author)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Author == author)
                {
                    Console.WriteLine($"{books[i].Name}, {books[i].Author}, {books[i].Year}");
                }
                if (i == books.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Книга не найдена");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        public void SearchByYear(int year)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Year == year)
                {
                    Console.WriteLine($"{books[i].Name}, {books[i].Author}, {books[i].Year}");
                }
                if (i == books.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Книга не найдена");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        public void ListBook()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{books[i].Name}, {books[i].Author}, {books[i].Year}");
            }
        }
        public void SortName()
        {
            books.Sort((book1, book2) => book1.Name.CompareTo(book2.Name));
        }
        public void SortAuthor()
        {
            books.Sort((book1, book2) => book1.Author.CompareTo(book2.Author));
        }
        public void SortYear()
        {
            books.Sort((book1, book2) => book1.Year.CompareTo(book2.Year));
        }
    }
}

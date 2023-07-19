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
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void SearchByName(string name) 
        {
            bool flag = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == name)
                {
                    Console.WriteLine($"{books[i].Name}, {books[i].Author}, {books[i].Year}");
                    flag = true;
                }
                if (i == books.Count && flag == false)
                {
                    Console.WriteLine("Книга не найдена");
                }
            }
        }
        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.Equals(author)).ToList();
        }
        public void SearchByYear(int year)
        {
            bool flag = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Year == year)
                {
                    Console.WriteLine($"{books[i].Name}, {books[i].Author}, {books[i].Year}");
                    flag = true;
                }
                if (i == books.Count && flag == false)
                {
                    Console.WriteLine("Книга не найдена");
                }
            }
        }
    }
}

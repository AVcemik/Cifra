using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Book> SearchByNAme(string name) 
        {
            return books.Where(b => b.Name.Equals(name)).ToList();
        }
        public List<Book> SearchByAuthor(string author)
        {
            return books.Where(b => b.Author.Equals(author)).ToList();
        }
        public List<Book> SearchByYear(string year)
        {
            return books.Where(b => b.Year.Equals(year)).ToList();
        }
    }
}

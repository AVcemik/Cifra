/*
 *                  Домашнее задание №24 Json
 */

using System.Text.Encodings.Web;
using System.Text.Json;

Library library = new Library();
if (File.Exists(Library._path))
{
    string jsonData = File.ReadAllText(Library._path);
    List<Book> listBook = JsonSerializer.Deserialize<List<Book>>(jsonData);
    for (int i = 0; i < listBook.Count; i++)
    {
        library.AddBook(listBook[i].Title, listBook[i].Author, listBook[i].Genre, listBook[i].Year);
    }
}


//library.AddBook("Гарри Поттер", "Джоан Роулинг", "Фэнтази", 2000);
//library.AddBook("Азбука", "Министерство образования", "учеба", 1900);
//library.AddBook("Люди как боги", "Кто то", "Фэнтази", 1980);

library.AddBook("еще книга", "фыв", "аврр", 2010);

library.WriteToJson();



class Book
{
    public string Title {  get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year {  get; set; }

    public Book(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }
}

class Library
{
    public static string _path = Directory.GetCurrentDirectory() + "\\DataLibrary.json";
    public List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(string title, string authoe, string genre, int year)
    {
        Books.Add(new Book(title, authoe, genre, year));
    }

    public void WriteToJson()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        using (StreamWriter streamWriter = new StreamWriter(_path))
        {
            string jsonSerialization = JsonSerializer.Serialize(Books, options);
            streamWriter.Write(jsonSerialization);
        }
    }
}
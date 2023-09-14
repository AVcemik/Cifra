// Домашняя работа

// Создать класс, содержащий динамический массив и количество элементов в нем.
// Добавить конструктор, который выделяет память под заданное количество элементов, и деструктор.
// Добавить методы, позволяющие заполнять массив случайными числами, переставлять в данном массиве
// элементы в случайном порядке, находить количество различных элементов в массиве, выводить массив на экран.

// Описать класс «домашняя библиотека».
// Предусмотреть возможность работы с произвольным числом книг, поиска книги по какому-либо признаку
// (например, по автору или по году издания), добавления книг в библиотеку, удаления книг из нее,
// сортировки книг по разным полям.


Masiv masiv = new Masiv(10);

masiv.FillArrayRandom();
masiv.PrintArray();
Console.WriteLine("Кол-во различных элементов = " + masiv.DifferentElementsArray());
Console.WriteLine("Кол-во элементо \"7\" = " + masiv.CountElementsArray(7));
masiv.ShuffleArray();
masiv.PrintArray();
Console.WriteLine();

HomeLibrary homeLibrary = new HomeLibrary();
homeLibrary.AddBook(new Book("Пеппи длиный чулок",1945, "Астрид Линдгрен"));
homeLibrary.AddBook(new Book("Буратино", 1936, "Алексей Николаевич Толстой"));
homeLibrary.AddBook(new Book("Люди как боги", 1966, "Сергей Александрович Снегов"));
homeLibrary.AddBook(new Book("Книга", 2023, "Я"));


while (true)
{

}




public class Masiv
{
    private int[] _array;

    public Masiv(int length)
    {
        if (length > 0)
        {
            _array = new int[length];
            for (int i = 0; i < length - 1; i++)
            {
                _array[i] = 0;
            }
        }
        else throw new ArgumentOutOfRangeException("Массив должен содержать хотя бы один элемент");
    }
    ~Masiv()
    {
        Console.WriteLine($"Объект был удален при значении someValue = {_array}");
    }

    /// <summary>
    /// Вывод массива
    /// </summary>
    public void PrintArray()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            if (i == 0) Console.Write($"| {_array[0]} | ");
            else
            {
                Console.Write($"{_array[i]} | ");
            }
        }
        Console.WriteLine();
    }
    /// <summary>
    /// Заполнение массива случайными числами
    /// </summary>
    public void FillArrayRandom()
    {
        Random random = new Random();

        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = random.Next(11);
        }
    }
    /// <summary>
    /// Перемешивание массива
    /// </summary>
    public void ShuffleArray()
    {
        Random random = new Random();
        int temp;
        int randomTemp;

        for (int i = 0; i < _array.Length; i++)
        {
            randomTemp = random.Next(_array.Length);

            temp = _array[i];
            _array[i] = _array[randomTemp];
            _array[randomTemp] = temp;
        }
    }
    /// <summary>
    /// Кол-во данных лементов
    /// </summary>
    /// <param name="digital">Элемент который нужно посчитать</param>
    /// <returns></returns>
    public int CountElementsArray(int digital)
    {
        int count = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            if (digital == _array[i]) count++;
        }
        return count;
    }
    /// <summary>
    /// Кол-во различных элементов
    /// </summary>
    /// <returns></returns>
    public int DifferentElementsArray()
    {
        int count = 0;

        for (int i = _array.Max(); i >= 0; i--)
        {
            for (int j = 0; j < _array.Length; j++)
            {
                if (_array[j] == i)
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}

public class HomeLibrary
{
    private List<Book> _books;

    public HomeLibrary()
    {
        _books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }
    public string SearchName(string name)
    {
        for (int i = 0; i < _books.Count; i++)
        {
            if (_books[i].Name == name)
            {
                return _books[i].PrintBook();
            }
        }
        return "Не удалось найти книгу";
    }
    public string SearchAge(int age)
    {
        for (int i = 0; i < _books.Count; i++)
        {
            if (_books[i].Age == age)
            {
                return _books[i].PrintBook();
            }
        }
        return "Не удалось найти книгу";
    }
    public string SearchAuthor(string author)
    {
        for (int i = 0; i < _books.Count; i++)
        {
            if (_books[i].Author == author)
            {
                return _books[i].PrintBook();
            }
        }
        return "Не удалось найти книгу";
    }
    
    public void SortBookName()
    {
        _books = _books.OrderBy(book => book.Name).ToList();
    }
    public void SortBookAge()
    {
        _books = _books.OrderBy(book => book.Age).ToList();
    }
    public void SortBookAuthor()
    {
        _books = _books.OrderBy(book => book.Author).ToList();
    }
    public void RemoveBookName(string name)
    {
        for (int i = 0; i < _books.Count; i++)
        {
            if (_books[i].Name == name)
            {
                _books.RemoveAt(i);
            }
        }
    }
    
}

public class Book
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Author { get; set; }

    public Book (string name, int age, string author)
    {
        Name = name;
        Age = age;
        Author = author;
    }

    public string PrintBook()
    {
        return $"{Name} | {Age} | {Author}";
    }

}
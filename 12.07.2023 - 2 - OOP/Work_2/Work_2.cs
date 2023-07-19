// Домашняя работа

// 2.	Описать класс «домашняя библиотека». Предусмотреть возможность работы с
// произвольным числом книг, поиска книги по какому-либо признаку (например, по
// автору или по году издания), добавления книг в библиотеку, удаления книг из нее,
// сортировки книг по разным полям.

using Work_2;
HomeLibery libery = new HomeLibery();
MenuClass m = new MenuClass();

//Наполнение, что бы что нибудь было
libery.AddBook(new Book("Книга 1", "Иванов Иванович", 2000));
libery.AddBook(new Book("Букварь", "Леонид Царский", 2000));
libery.AddBook(new Book("Книга 2", "Иванов Иванович", 1997));

while (true)
{
    m.ListMenu();
    Console.Write("Введите номер меню: ");

    Console.Write("Введите номер меню: ");
    m.Count = byte.Parse(Console.ReadLine()!);

    if (m.Count == 1)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.Write("Введите название книги: ");
        libery.SearchByName(Console.ReadLine()!);
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }
    else if (m.Count == 2)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.Write("Введите автора книги: ");
        libery.SearchByAuthor(Console.ReadLine()!);
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }
    else if (m.Count == 3)
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.Write("Введите год книги: ");
        libery.SearchByYear(int.Parse(Console.ReadLine()!));
        Console.WriteLine("------------------------------");
        Console.WriteLine();
    }
    else if (m.Count == 4)
    {

    }
    else if (m.Count == 5)
    {

    }
    else if (m.Count == 6)
    {

    }
    else if (m.Count == 7)
    {
        Book tempBook = new Book();
        Console.Write("Введите название книги: ");
        tempBook.Name = Console.ReadLine()!;
        Console.Write("Введите автора: ");
        tempBook.Author = Console.ReadLine()!;
        Console.Write("Введите год: ");
        tempBook.Year = int.Parse(Console.ReadLine()!);
        libery.AddBook(new Book (tempBook.Name, tempBook.Author, tempBook.Year));
    }
    else if (m.Count == 8)
    {

    }
}

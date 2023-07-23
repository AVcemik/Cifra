// Домашняя работа

// 2.	Описать класс «домашняя библиотека». Предусмотреть возможность работы с
// произвольным числом книг, поиска книги по какому-либо признаку (например, по
// автору или по году издания), добавления книг в библиотеку, удаления книг из нее,
// сортировки книг по разным полям.

using Work_2;
HomeLibery libery = new HomeLibery();
Print print = new Print();

//Наполнение, что бы что нибудь было
libery.AddBook(new Book("Книга 1", "Иванов Иванович", 2000));
libery.AddBook(new Book("Букварь", "Леонид Царский", 2000));
libery.AddBook(new Book("Книга 2", "Иванов Иванович", 1997));

while (true)
{
    print.ListMenu();
    Console.Write("Введите номер меню: ");
    print.Count = byte.Parse(Console.ReadLine()!);

    if (print.Count == 1)
    {
        print.RazdelitelStart();
        Console.Write("Введите название книги: ");
        libery.SearchByName(Console.ReadLine()!);
        print.RazdelitelEnd();
    }
    else if (print.Count == 2)
    {
        print.RazdelitelStart();
        Console.Write("Введите автора книги: ");
        libery.SearchByAuthor(Console.ReadLine()!);
        print.RazdelitelEnd();
    }
    else if (print.Count == 3)
    {
        print.RazdelitelStart();
        Console.Write("Введите год книги: ");
        libery.SearchByYear(int.Parse(Console.ReadLine()!));
        print.RazdelitelEnd();
    }
    else if (print.Count == 4)
    {
        libery.SortName();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Книги отсортированны по названию");
        Console.ForegroundColor= ConsoleColor.Gray;
    }
    else if (print.Count == 5)
    {
        libery.SortAuthor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Книги отсортированны по автору");
        Console.ForegroundColor= ConsoleColor.Gray;
    }
    else if (print.Count == 6)
    {
        libery.SortYear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Книги отсортированны по году");
        Console.ForegroundColor= ConsoleColor.Gray;
    }
    else if (print.Count == 7)
    {
        Book tempBook = new Book();
        Console.Write("Введите название книги: ");
        tempBook.Name = Console.ReadLine()!;
        Console.Write("Введите автора: ");
        tempBook.Author = Console.ReadLine()!;
        Console.Write("Введите год: ");
        tempBook.Year = int.Parse(Console.ReadLine()!);
        libery.AddBook(new Book(tempBook.Name, tempBook.Author, tempBook.Year));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Книга успешно добавлена");
        Console.ForegroundColor= ConsoleColor.Gray;
    }
    else if (print.Count == 8)
    {
        Console.Write("Введите название удаляемой книги: ");
        libery.RemoveBook(Console.ReadLine()!);
    }
    else if (print.Count == 9)
    {
        print.RazdelitelStart();
        libery.ListBook();
        print.RazdelitelEnd();
    }
    else if (print.Count == 10)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный номер меню");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    print.Pause();
}

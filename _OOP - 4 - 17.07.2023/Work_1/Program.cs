// Составить описание класса для определения одномерных массивов
// строк фиксированной длины. Предусмотреть контроль выхода за
// пределы массива, возможность обращения к отдельным строкам
// массива по индексам, выполнения операций поэлементного сцепления
// двух массивов с образованием нового массива, слияния двух
// массивов с исключением повторяющихся элементов, а также вывод
// на экран элемента массива по заданному индексу и всего массива.

using Work_1;

Console.Write("Введите длину массива: ");
Masiv.SetLength(int.Parse(Console.ReadLine()!));

Masiv mas1 = new();
Masiv mas2 = new();
Masiv mas3 = new();
Masiv mas4 = new();

mas1.InputMasiv(1);
mas2.InputMasiv(2);

mas1.Print(1);
mas2.Print(2);

Console.WriteLine();
Console.WriteLine("Слияние двух массивов");
mas3 = mas1;
mas3.Concat(mas2);
mas3.Print(3);

Console.WriteLine();
Console.WriteLine("Слияние двух массивов с исключением повторов");
mas4 = mas1;
mas4.MergeUnique(mas2);
mas4.Print(4);

Console.WriteLine();
Console.Write("Введите номер элемента последнего массива для его вывода: ");
mas4.PrintElement(int.Parse(Console.ReadLine()!));



//Console.Write($"Введите {mas.Lenght} символов: ");
//mas = char.Parse(Console.ReadLine());

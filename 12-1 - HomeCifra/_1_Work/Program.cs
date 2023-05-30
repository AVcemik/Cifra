// Домашнее задание. Тема 12. Урок 1.
// Операторы ветвления Switch/ Case.
// Калькулятор: пользователь может выбрать операцию
// (сложение, вычитание, умножение, деление), ввести два числа и получить результат

double a = InputDouble("Введите первое число: ");
double b = InputDouble("Введите второе число: ");

while (true)
{
    bool cheack;
    Console.Write("Введите оператор \"+\", \"-\", \"*\", \"/\"");
    string? operations = Console.ReadLine();
    switch (operations)
    {
        case "+":
            Console.WriteLine($"\n{a} + {b} = {a+b}:F2  ");
            cheack = true;
            break;
        case "-":
            Console.WriteLine($"\n{a} - {b} = {a-b}:F2");
            cheack = true;
            break;
        case "*":
            Console.WriteLine($"\n{a} * {b} = {a*b:F2}");
            cheack = true;
            break;
        case "/":
            Console.WriteLine($"\n{a} / {b} = {a/b:F2}");
            cheack = true;
            break;
        default:
            cheack = false;
            break;
    }

    if (cheack == true) break;
    else
    {
        Console.WriteLine("\nВы ввели не верный оператор!!!");
        continue;
    }

}

Console.WriteLine("\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);


static double InputDouble(string text)
{
    while (true)
    {
        Console.Write(text);
        string? temp = Console.ReadLine();
        bool cheack = double.TryParse(temp.Replace('.',','), out double result);

        if (cheack == true) return result;
        else
        {
            Console.WriteLine("\nВы ввели не число!!!");
            continue;
        }
    }
}

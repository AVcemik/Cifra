// Домашнее задание. Тема 12. Урок 2.
// Операторы ветвления Switch/Case.

// Пользователю на выбор дается 5 ароматов духов:
// ● Chanel
// ● Dior
// ● Tom Ford
// ● Gucci
// ● Yves Saint Laurent
// В зависимости от его выбора выводить ему краткую информацию об аромате

Console.WriteLine("В нашем магазине есть 5 араматов духов");
Console.WriteLine("\nнажмите людую клавишу что бы их увидеть...");
Console.ReadKey();
Console.Clear();

Console.WriteLine("1 - Chanel\n2 - Dior\n3 - Tom Ford\n4 - Gucci\n5 - Yves Saint Laurent\n");
byte number = InputByte("Для получения информации об аромате, введите его номер: ");

switch (number)
{
    case 1:
        Console.WriteLine("\nChanel - французский модный дом с известными ароматами, включая Chanel No. 5, Coco Mademoiselle, Chance и другие. Ароматы Chanel символизируют элегантность и роскошь.");
        break;
    case 2:
        Console.WriteLine("\nDior - престижный французский модный дом с известными ароматами, включая J'adore и Miss Dior.");
        break;
    case 3:
        Console.WriteLine("\nTom Ford - американский дизайнер с роскошными ароматами, включая Black Orchid и другие смелые композиции.");
        break;
    case 4:
        Console.WriteLine("\nGucci - модный бренд, известный своими стильными и роскошными ароматами.");
        break;
    case 5:
        Console.WriteLine("\nYves Saint Laurent - модный бренд с изысканными ароматами.");
        break;
    default: Console.WriteLine("Такого аромата у нас нету :(");
        break;
}

Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);

static byte InputByte(string text)
{
    while (true)
    {
        Console.Write(text);
        string? temp = Console.ReadLine();
        bool cheack = byte.TryParse(temp.Replace('.', ','), out byte result);

        if (cheack == true) return result;
        else
        {
            Console.WriteLine("\nВы ввели недопустимое значение...");
            continue;
        }
    }
}
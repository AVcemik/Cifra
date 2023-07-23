// Домашнее задание.
// Тема 5. Урок 2.
// Константы и литералы.
// 1. Зарисуйте в консоли чек, используя известные вам методы
// программирования: константы, литералы, интерполяцию.

Console.Write("Введите Кол-во: ");
decimal Number = decimal.Parse(Console.ReadLine());
Console.Write("Введите цену: ");
decimal Price = decimal.Parse(Console.ReadLine());
decimal ResultPrice = Number * Price;
decimal NDS = ResultPrice * (18M / 100);



Console.WriteLine("         ООО <<КОМПАНИЯ>>          ");
Console.WriteLine("         ДОБРО ПОЖАЛОВАТЬ!         ");
Console.WriteLine("КАССОВЫЙ ЧЕК/ПРИХОД                ");
Console.WriteLine("НОМЕР СМЕНЫ 000008       ЧЕК 000002");
Console.WriteLine("СНО                             ОСН");
Console.WriteLine("ПОЛНЫЙ РАСЧЕТ (4)                  ");
Console.WriteLine("  №0003 Краска маслянная арт.0345  ");
Console.WriteLine($"  1   {Number}х   {Price}    ={ResultPrice}");
Console.WriteLine($"ИТОГ                       ={ResultPrice}");
Console.WriteLine($"В: СУММА НДС 18%            ={NDS}");
Console.WriteLine("НАЛИЧНЫМИ                  =3000.00");
Console.WriteLine("ЭЛЕКТРОННЫМИ                  =0.00");
Console.WriteLine("09/06/2017 11:42 Кассир 1          ");
Console.WriteLine("ФИО                                ");
Console.WriteLine("ЗН ККТ             0535860004001003");
Console.WriteLine("РН ККТ             0000000015018840");
Console.WriteLine("ИНН                      7721306333");
Console.WriteLine("ФН                 9999078900002273");
Console.WriteLine("ФД 0000000043         ФП 0159733624");
Console.WriteLine("\n              СПАСИБО");

Console.WriteLine("\nНажмите Enter для продолжения...");
Console.ReadLine();
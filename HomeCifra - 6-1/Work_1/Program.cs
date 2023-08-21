// Домашнее задание. Тема 6. Урок 1.
// Преоброзование типов и способы

// Есть исходный тип данных :
// string, хранящий число 28
// Конвентируйте его в следующие типы данных, последовательно:
// сначало в byte,
// затем из предыдущего в uint,
// затем из предыдущего в int,
// затем из предыдущего в long,
// затем из предыдущего в double.

string str = "28";

uint _uint = uint.Parse(str);
int _int = Convert.ToInt32(_uint);
long _long = Convert.ToInt64(_int);
double _double = Convert.ToDouble(_long);

Console.WriteLine("string - " + str.GetType()!);
Console.WriteLine("uint - " + _uint.GetType()!);
Console.WriteLine("int - " + _int.GetType()!);
Console.WriteLine("long - " + _long.GetType()!);
Console.WriteLine("double - " + _double.GetType()!);
// 3. Составить программу вывода на экран в одну строку трех любых чисел с 
// двумя пробелами между ними.

using _3_Work;

int _Number1 = AddFunc.InputNumber("первое");
int _Number2 = AddFunc.InputNumber("второе");
int _Number3 = AddFunc.InputNumber("третье");
Console.WriteLine();

Console.WriteLine($"{_Number1}  {_Number2}  {_Number3}");

AddFunc.ExitProgramm();
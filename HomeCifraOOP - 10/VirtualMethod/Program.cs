/*
    Напишите программу, в которой есть базовый класс с открытым целочисленным полем. 
    В классе описан виртуальный индексатор, позволяющий считывать цифры в десятичном 
    представлении числа (значение поля). 
    На основе базового класса создается производный класс, в котором появляется еще 
    одно открытое целочисленное поле. 
    В производном классе описывается версия индексатора с двумя индексами: 
    первый индекс определяет поле, значение которого используется, а второй индекс определяет разряд, 
    для которого считывается цифра. 
    Индексатор с одним индексом переопределяется так, что вычисления (считывание цифры в десятичном 
    представлении числа) производятся на основе значения, равного сумме значений полей индексируемого 
    объекта.
 */

SecondBases number = new SecondBases(5);
number[0] = 165489;
number[1] = 597615;
number[2] = 874135;
number[3] = 913257;
number[4] = 995229;

Console.WriteLine(number[0, 3]);
Console.WriteLine(number[1, 1]);
Console.WriteLine(number[2, 5]);
Console.WriteLine(number[3, 4]);
Console.WriteLine(number[4, 6]);

class Bases
{
    public int[] number;
    public Bases(int index)
    {
        number = new int[index];
    }
    public virtual int this[int index]
    {
        get
        {
            return number[index];
        }
        set
        {
            number[index] = value;
        }
    }
} 
class SecondBases : Bases
{
    public SecondBases(int index) : base(index)
    {
    }
    public int this[int index, int index2]
    {
        get
        {
            int temp = number[index];
            for (int i = 1; i < index2; i++)
            {
                temp /= 10;
            }
            return temp % 10;
        }
        set
        {

        }
    }
}
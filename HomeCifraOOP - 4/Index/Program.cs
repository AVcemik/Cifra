/*
                    Домашняя работа #4 Индексаторы - Лубенец Александр
    Составить описание класса для определения одномерных массивов строк фиксированной длины. 
    Предусмотреть контроль выхода за пределы массива, возможность обращения к отдельным строкам 
    массива по индексам, выполнения операций поэлементного сцепления двух массивов с образованием 
    нового массива, слияния двух массивов с исключением повторяющихся элементов, а также вывод 
    на экран элемента массива по заданному индексу и всего массива.
 */


Masiv masiv1 = new Masiv(3,3);
Masiv masiv2 = new Masiv(4,4);
Masiv masiv3 = new Masiv();

masiv1[0] = "asd";
masiv1[1] = "zxc";
masiv1[2] = "qwe";

masiv2[0] = "lkjs";
masiv2[1] = "zxcc";
masiv2[2] = "qwrt";
masiv2[3] = "ggfh";

masiv3.Merge(masiv1, masiv2);

for (int i = 0; i < masiv1.Length; i++)
{
    Console.WriteLine(masiv3[i]);
}

class Masiv
{
    public string[] line;
    private int _numberElement;
    public int Length;
    public Masiv()
    {
        line = new string[0];
        _numberElement = 0;
        Length = 0;
    }
    public Masiv(int length, int numberElement)
    {
        line = new string[length];
        _numberElement = numberElement;
        Length = length;
    }

    public string this[int index]
    {
        get
        {
            if (Ok(index))
            {
                return line[index];
            }
            return "Вы вышли за пределы индекса";
        }
        set
        {
            if (Ok(index))
            {
                if (value.Length == _numberElement)
                {
                    line[index] = value;
                }
                else
                {
                    throw new Exception ("Записать в массив можно строго 3 символа");
                }
            }
        }
    }
    private bool Ok(int index)
    {
        if (index >=0 && index < Length)
        {
            return true;
        }
        return false;
    }
    public void Merge(Masiv masiv1, Masiv masiv2)
    {
        string temp = "";

        if (masiv1.Length > masiv2.Length)
        {
            Length = masiv1.Length;
            line = new string[masiv1.Length];
        }
        else if (masiv1.Length < masiv2.Length)
        {
            Length = masiv2.Length;
            line = new string[masiv2.Length];
        }
        _numberElement = masiv1[0].Length + masiv2[0].Length;

        for (int i = 0; i < masiv1.Length; i++)
        {
            for (int j = 0; j < masiv1._numberElement; j++)
            {
                temp += masiv1[i][j];
            }
            line[i] = temp;
            temp = "";
        }

        for (int i = 0; i < masiv2.Length; i++)
        {
            temp = line[i];
            for (int j = 0; j < masiv2._numberElement; j++)
            {
                if (temp == null)
                {
                    for (int f = 0; f < _numberElement; f++)
                    {
                        temp += " ";
                    }
                }
                if (temp[j] != masiv2[i][j])
                {
                    temp += masiv2[i][j];
                }
            }
            line[i] = temp;
        }
        
    }

}
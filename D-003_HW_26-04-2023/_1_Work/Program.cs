namespace _1_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Лубенец - 12.109
            // Дан двумерный массив из пятнадцати строк и двух столбцов.
            // Найти номера двух соседних строк, сумма элементов в которых минимальна.

            int _result = -1;
            int _x = 15;      // Размер массива 0
            int _y = 4;     // Размер массива 1
            int[,] _array2D = new int[_x,_y];

            _array2D = AddFunc.Fill2DArray(_x, _y);
            AddFunc.Input2DArray(_array2D);

            for (int i = 0, result = int.MaxValue; i < _array2D.GetLength(0); i++)
            {
                if (result >= _array2D[i,1] + _array2D[i, 2])
                {
                    result = _array2D[i, 1] + _array2D[i, 2];
                    _result = _array2D[i, 0];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("В строке № " + _result + " минимальная сумма элементов");
            AddFunc.ExitProgramm();
        }
    }
}
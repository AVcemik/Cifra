// Задание 1.
// Составить описание класса для представления времени.
// Предусмотреть возможности установки времени и изменения его отдельных полей
// (час, минута, секунда) с проверкой допустимости вводимых значений.
// В случае недопустимых значений полей выбрасываются исключения.
// Создать методы изменения времени на заданное количество часов, минут и секунд.

// Задание 2.
// Описать класс, представляющий треугольник.
// Предусмотреть методы для создания объектов,
// вычисления площади, периметра и точки пересечения медиан.
// Описать методы для получения состояния объекта.

MyTime time1 = new MyTime(23, 55, 45);
MyTime time2 = new MyTime();
MyTime time3 = new MyTime();

time2.SetHour(11);
time2.SetMinute(23);
time2.SetSecond(3);

Console.WriteLine($"Время1 = {time1.GetTime()}");
Console.WriteLine($"Время2 = {time2.GetTime()}");
Console.WriteLine($"Время3 = {time3.GetTime()}");

Console.WriteLine();

Triangle tringleOne = new Triangle(3, 4, 2);
Triangle tringleTwo = new Triangle(0, 1, 2, 2, 4, 0);

Console.WriteLine($"Площаль первого треугольника: {tringleOne.Area():F2}");
Console.WriteLine($"Площадь второго треугольника: {tringleTwo.Area():F2}");
Console.WriteLine($"Площадь треугольника по длинам сторон: {Triangle.Area(2, 5, 4):F2}");
Console.WriteLine($"Площадь треугольника по координатам точек: {Triangle.Area(2, 1, 3, 3, 5, 1):F2}");

Console.WriteLine();

Console.WriteLine($"Периметр первого треугольника: {tringleOne.Perimetr():F2}");
Console.WriteLine($"Периметр второго треугольника: {tringleTwo.Perimetr():F2}");
Console.WriteLine($"Периметр треугольника по длинам сторон: {Triangle.Perimetr(2, 5, 4):F2}");
Console.WriteLine($"периметр треугольника по координатам точек: {Triangle.Area(2, 1, 3, 3, 5, 1):F2}");

Console.WriteLine();

Console.WriteLine($"Пересечение медиан первого треугольника не посчитать из за отсутствия координат");
Console.WriteLine($"Пересечение медиана второго треугольника {tringleTwo.Mediana():F2}");
Console.WriteLine($"Пересечение медиан треугольника {Triangle.Mediana(2, 1, 3, 3, 5, 1):F2}");

Console.WriteLine();

Console.WriteLine("Нажмите любую клавишу для завршения программы...");
Console.ReadKey();


/// <summary>
/// Класс работы со временем
/// </summary>
public class MyTime
{
    private int _hour;
    private int _minute;
    private int _second;

    /// <summary>
    /// Конструктор по умолчанию устанавливает все значения по 0
    /// </summary>
    public MyTime()
    {
        _hour = 0;
        _minute = 0;
        _second = 0;
    }
    /// <summary>
    /// Конструктор для установки времени
    /// </summary>
    /// <param name="hour">Часы</param>
    /// <param name="minute">Минуты</param>
    /// <param name="second">Секунды</param>
    public MyTime(int hour, int minute, int second)
    {
        SetTime(hour, minute, second);
    }
    /// <summary>
    /// Метод изменения часов
    /// </summary>
    /// <param name="hour">часы</param>
    /// <exception cref="Exception">Диапозон (0,23)</exception>
    public void SetHour(int hour)
    {
        if (hour >= 0 && hour < 24)
            _hour = hour;
        else
        {
            throw new Exception("Не корректно установлены часы");
        }
    }
    /// <summary>
    /// Метод изменения минут
    /// </summary>
    /// <param name="minute">Минуты</param>
    /// <exception cref="Exception">Диапозон (0,59)</exception>
    public void SetMinute(int minute)
    {
        if (minute >= 0 && minute < 60)
            _minute = minute;
        else
        {
            throw new Exception("Не корректно установлены минуты");
        }
    }
    /// <summary>
    /// Метод изменения секунд
    /// </summary>
    /// <param name="second">Секунды</param>
    /// <exception cref="Exception">Диапозон (0,59)</exception>
    public void SetSecond(int second)
    {
        if (second >= 0 && second < 60)
            _second = second;
        else
        {
            throw new Exception("Не корректно установлены секунды");
        }
    }
    /// <summary>
    /// Метод изменения полного времени Часы:Минуты:Секунды
    /// </summary>
    /// <param name="hour">Часы</param>
    /// <param name="minute">Минуты</param>
    /// <param name="second">Секунды</param>
    public void SetTime(int hour, int minute, int second)
    {
        SetHour(hour);
        SetMinute(minute);
        SetSecond(second);
    }
    /// <summary>
    /// Метод возрата времени в виде string
    /// </summary>
    /// <returns>Часы:Минуты:Секунды</returns>
    public string GetTime()
    {
        return $"{_hour}:{_minute}:{_second}";
    }
}

public class Triangle
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    private double _pointAx;
    private double _pointAy;
    private double _pointBx;
    private double _pointBy;
    private double _pointCx;
    private double _pointCy;


    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public Triangle(double pointAx, double pointAy, double pointBx, double pointBy, double pointCx, double pointCy)
    {
        _pointAx = pointAx;
        _pointAy = pointAy;
        _pointBx = pointBx;
        _pointBy = pointBy;
        _pointCx = pointCx;
        _pointCy = pointCy;
        _sideA = PointToSide(pointAx, pointAy, pointBx, pointBy);
        _sideB = PointToSide(pointBx, pointBy, pointCx, pointCy);
        _sideC = PointToSide(pointCx, pointCy, pointAx, pointAy);
    }

    /// <summary>
    /// Метод подсчета площади треугольника
    /// </summary>
    /// <returns>Результат</returns>
    public double Area()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    /// <summary>
    /// Статичный метод посчета площади треугольника через длины сторон
    /// </summary>
    /// <param name="sideA">Сторона А</param>
    /// <param name="sideB">Сторона В</param>
    /// <param name="sideC">Сторона С</param>
    /// <returns>Результат</returns>
    public static double Area(double sideA, double sideB, double sideC)
    {
        double s = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
    }

    /// <summary>
    /// Статичный метод посчета площади треугольника через координаты точек
    /// </summary>
    /// <param name="sideA">Сторона А</param>
    /// <param name="sideB">Сторона В</param>
    /// <param name="sideC">Сторона С</param>
    /// <returns>Результат</returns>
    public static double Area(double pointAx, double pointAy, double pointBx, double pointBy, double pointCx, double pointCy)
    {
        return Area(PointToSide(pointAx, pointAy, pointBx, pointBy), PointToSide(pointBx, pointBy, pointCx, pointCy), PointToSide(pointCx, pointCy, pointAx, pointAy));
    }

    /// <summary>
    /// Метод подсчета треугольника
    /// </summary>
    /// <returns>Результат</returns>
    public double Perimetr()
    {
        return _sideA + _sideB + _sideC;
    }

    /// <summary>
    /// Статичный метод посчета периметра треугольника через длины сторон
    /// </summary>
    /// <param name="sideA">Сторона А</param>
    /// <param name="sideB">Сторона В</param>
    /// <param name="sideC">Сторона С</param>
    /// <returns>Результат</returns>
    public static double Perimetr(double sideA, double sideB, double sideC)
    {
        return sideA + sideB + sideC;
    }

    /// <summary>
    /// Статичный метод посчета периметра треугольника по координатам точек
    /// </summary>
    /// <param name="sideA">Сторона А</param>
    /// <param name="sideB">Сторона В</param>
    /// <param name="sideC">Сторона С</param>
    /// <returns>Результат</returns>
    public static double Perimetr(double pointAx, double pointAy, double pointBx, double pointBy, double pointCx, double pointCy)
    {
        return Perimetr(PointToSide(pointAx, pointAy, pointBx, pointBy), PointToSide(pointBx, pointBy, pointCx, pointCy), PointToSide(pointCx, pointCy, pointAx, pointAy));
    }

    /// <summary>
    /// Метод нахождение пересечения медиан
    /// </summary>
    /// <returns></returns>
    public string Mediana()
    {
        return $"x:{(_pointAx + _pointBx + _pointCx) / 3:F2} y:{(_pointAy + _pointBy + _pointCy) / 3:F2}";
    }

    /// <summary>
    /// Статичный метод подсчета медиан
    /// </summary>
    /// <param name="pointAx"></param>
    /// <param name="pointAy"></param>
    /// <param name="pointBx"></param>
    /// <param name="pointBy"></param>
    /// <param name="pointCx"></param>
    /// <param name="pointCy"></param>
    /// <returns></returns>
    public static string Mediana(double pointAx, double pointAy, double pointBx, double pointBy, double pointCx, double pointCy)
    {
        return $"x:{(pointAx + pointBx + pointCx) / 3:F2} y:{(pointAy + pointBy + pointCy) / 3:F2}";
    }

    /// <summary>
    /// Статичный метод преоброзования координат в длины
    /// </summary>
    /// <param name="pointAx"></param>
    /// <param name="pointAy"></param>
    /// <param name="pointBx"></param>
    /// <param name="pointBy"></param>
    /// <returns></returns>
    private static double PointToSide(double pointAx, double pointAy, double pointBx, double pointBy)
    {
        return Math.Sqrt(Math.Pow(pointBx - pointAx, 2) + Math.Pow(pointBy - pointAy, 2));
    }
}
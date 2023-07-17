using System.Drawing;
using Work_2;
// Домашняя работа (Work_1, Work_2)

// 2.	Описать класс, представляющий треугольник.
// Предусмотреть методы для создания объектов, вычисления площади,
// периметра и точки пересечения медиан. Описать методы для
// получения состояния объекта.


Triangle triang = new Triangle();
Console.WriteLine("Создаем треугольник");
Console.WriteLine();


Console.WriteLine();
Console.WriteLine($"Площадь: {triang.getArea():F2}");
Console.WriteLine($"Периметр: {triang.getPerimetr():F2}");
Console.WriteLine($"точка пересечения медиан: {triang.getMedianPoint(0):F2}, {triang.getMedianPoint(1):F2}");
triang.getState();
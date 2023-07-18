using System.Drawing;
using Work_2;
// Домашняя работа (Work_1, Work_2)

// 2.	Описать класс, представляющий треугольник.
// Предусмотреть методы для создания объектов, вычисления площади,
// периметра и точки пересечения медиан. Описать методы для
// получения состояния объекта.

AddFunc addFunc = new ();

addFunc.CreateTriangle();
addFunc.InputData();
Console.WriteLine();

addFunc.Area();
addFunc.Perimetr();
addFunc.Mediana();
addFunc.StatsTriangle();
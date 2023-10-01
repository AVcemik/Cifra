/*
            Объектно ориентированное программирование на C# Тема 15.
                Домашнее задание. Делегаты и лямбда функции

Создайте класс Building с следующими свойствами:
    - BuildingName (название здания, строковое)
    - Height (высота здания в метрах, числовое)
    - Floors (количество этажей, числовое)
    - TotalArea (общая площадь в квадратных метрах, числовое)
    - Location (местоположение здания, строковое)
Определите метод CalculateVolume(), который будет вычислять объем здания. 
Объем можно приближенно рассчитать, умножив высоту здания на его общую площадь. 
Метод должен возвращать объем в кубических метрах.

Создайте массив из 3 зданий, задав разные характеристики для каждого.
Определите делегат с сигнатурой для метода CalculateVolume.
Создайте метод, который принимает массив зданий и делегат, 
а затем вызывает метод CalculateVolume для каждого здания в массиве с помощью делегата. 
Выведите результаты расчетов на экран
*/

Building[] building = new Building[3]{new Building(), new Building(), new Building()};
MyDelegate myDelegate = Building.CalculateVolume;

building[0].BuildingName = "Здание_1";
building[0].Height = 3;
building[0].Floors = 1;
building[0].TotalArea = 60;
building[0].Location = "Калининград";

building[1].BuildingName = "Здание_2";
building[1].Height = 30;
building[1].Floors = 20;
building[1].TotalArea = 1000;
building[1].Location = "Калининград";

building[2].BuildingName = "Здание_3";
building[2].Height = 7;
building[2].Floors = 2;
building[2].TotalArea = 500;
building[2].Location = "Москва";

PrintVolume(building, myDelegate);

static void PrintVolume(Building[] building, MyDelegate myDelegate)
{
    for (int i = 0; i < building.Length; i++)
    {
        Console.WriteLine(building[i].BuildingName + ": " + myDelegate(building[i].Height, building[i].TotalArea));
    }
}

public class Building
{
    public string BuildingName { get; set; }
    public double Height { get; set; }
    public int Floors { get; set; }
    public double TotalArea { get; set; }
    public string Location { get; set; }

    public static double CalculateVolume(double height, double totalArea)
    {
        return height * totalArea;
    }
}

delegate double MyDelegate(double height, double totalArea);

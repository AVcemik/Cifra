﻿// Домашняя работа

// 1.   Создать класс, содержащий динамический массив и количество элементов в нем.
// Добавить конструктор, который выделяет память под заданное количество элементов,
// и деструктор. Добавить методы, позволяющие заполнять массив случайными числами,
// переставлять в данном массиве элементы в случайном порядке, находить количество
// различных элементов в массиве, выводить массив на экран.


using _12._07._2023___2___OOP;

Console.Write("Введите размер массива: ");
MyClass m = new MyClass(int.Parse(Console.ReadLine()!));

Console.WriteLine();
m.FillRandom();
Console.WriteLine("Заполненый массив: ");
m.InputMas();
m.Shuffle();
Console.WriteLine("перемешанный массив: ");
m.InputMas();
Console.WriteLine($"Кол-во различных элементов в массиве: {m.CountElement()}");

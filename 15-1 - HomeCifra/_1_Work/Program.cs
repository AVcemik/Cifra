﻿// Домашнее задание. Тема 15. Урок 1.
// Одномерный массив.

// Создайте строковый массив, размеров в 10 ячеек.
// Заполните его словами в следующем порядке:
// “освоении”, “остальное”, “по плечу”, “сложный”, “но если”,
// “программирования”, “многие бросают”, “остальное будет”,
// “освоить их,”, “этап в”, “на этом этапе,”, “Массивы -”
// Соберите в новом массиве полноценную фразу.

string[] mas = new string[12] 
{ 
    "освоение", 
    "остальное", 
    "по плечу", 
    "сложный", 
    "но если", 
    "программирования", 
    "многие бросают", 
    "будет", 
    "освоить их", 
    "этап в", 
    "на этом этапе", 
    "Массивы -" 
};

string[] newMas = new string[12];
int[] poryadok = new int[12] {12, 4, 10, 1, 6, 11, 7, 5, 9, 2, 8, 3 };

for (int i = 0; i < newMas.Length; i++)
{
    newMas[i] = mas[poryadok[i]-1];
    Console.Write(newMas[i] + " ");
}

Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadLine();
Environment.Exit(0);
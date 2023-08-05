using Work_1;
// Домашняя работа
// 1.	Задача на взаимодействие между классами.
// Разработать систему «Вступительные экзамены».
// Абитуриент регистрируется на Факультет, сдает Экзамены.
// Преподаватель выставляет Оценку.
// Система подсчитывает средний бал и определяет Абитуриента,
// зачисленного в учебное заведение.

// абитуриент > факудьтет > Экзамен
// Преподователь > Оценка

Facult programist = new("Програмист");

Abiturient abiturient1 = new("Иванов")
{
    Facult = programist
};
Teacher teacher = new("Преподователь")
{
    Facult = programist
};
Exam exam = new();


teacher.Facult.Exam!.SetName(abiturient1.Name);
teacher.SetMark(5);

Console.WriteLine();
Console.WriteLine($"Средний был: {abiturient1.Facult.Exam!.Mark!.Marks}");


//oop.Exam!.Mark = 5;


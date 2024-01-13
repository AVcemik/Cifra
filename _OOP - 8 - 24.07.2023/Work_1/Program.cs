using Work_1;

Exam matematika = new Exam("Математика");
Exam informatika = new Exam("Информатика");
Exam programirovanie = new Exam("Програмирование");

Facult programist = new("Програмист");
programist.AddExam(matematika);
programist.AddExam(informatika);
programist.AddExam(programirovanie);

Student studentOne = new("Иванов", programist);

Teacher teacher = new("Преподователь");

teacher.SetMark(studentOne, studentOne.Facult.Exam[0], 72);
teacher.SetMark(studentOne, studentOne.Facult.Exam[1], 100);
teacher.SetMark(studentOne, studentOne.Facult.Exam[2], 93);


Resultat(studentOne);
static void Resultat(Student student)
{
	int succes = 80;
    double averageMark = 0;
	for (int i = 0; i < student.Examen.Count; i++)
	{
		averageMark += student.Examen[i].Mark;
	}
	averageMark /= student.Examen.Count;

	if (averageMark >= succes)
        Console.WriteLine($"Проходной бал {succes}\nВаш средний бал {averageMark:F2}\nВы поступили");
	else
        Console.WriteLine($"Проходной бал {succes}\nВаш средний бал {averageMark:F2}\nВы не поступили");
}


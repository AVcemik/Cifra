using System.Text.RegularExpressions;
using System;

namespace _1_Work
{
    internal class _1_Work
    {
        static void Main(string[] args)
        {
            // Лубенец стр 126-7

            // Описать структуру с именем PERSON, содержащую поля:
            // Name – фамилия и инициалы,
            // FAC – факультет,
            // GROUP – группа,
            // DATE – дата поступления в ВУЗ(год, месяц, число).
            // Написать программу, выполняющую:
            // - ввод с клавиатуры данных в массив VUZ, состоящий из 10 элементов типа PERSON,
            // записи должны быть упорядочены по дате поступления в ВУЗ;
            // - вывод на экран информации о студентах, упорядоченной по факультетам,
            // группам, дате поступления. В каждой группе фамилии должны быть расположены
            // в алфавитном порядке.

            Person[] _vuz = new Person[10];

            //InputVuzInfo(_vuz);
            TestInputVuzInfo(_vuz); // Это заполненый массив для теста, что бы не заполнять в ручную
            SortDate(_vuz);         // Сортировка по зачислению студентов в структуре
            OutputVuzInfo(_vuz);    // Вывод информации о студентах

            ExitProgramm();

            void TestInputVuzInfo(Person[] vuz)
            {
                vuz[0].name = "Иванов И.И.";
                vuz[0].fac = "Програмирование";
                vuz[0].group = 2212;
                vuz[0].dateup = new DateTime(2000, 1, 1);

                vuz[1].name = "Лубенец А.В.";
                vuz[1].fac = "Програмирование";
                vuz[1].group = 2211;
                vuz[1].dateup = new DateTime(1987, 11, 6);

                vuz[2].name = "Бедников В.В.";
                vuz[2].fac = "Дизайнер";
                vuz[2].group = 2213;
                vuz[2].dateup = new DateTime(2022, 11, 1);

                vuz[3].name = "Богатников С.Р.";
                vuz[3].fac = "Дизайнер";
                vuz[3].group = 2211;
                vuz[3].dateup = new DateTime(1902, 5, 13);

                vuz[4].name = "Беляшев П.А.";
                vuz[4].fac = "Дизайнер";
                vuz[4].group = 2212;
                vuz[4].dateup = new DateTime(2000, 1, 13);

                vuz[5].name = "Березнякова Н.И.";
                vuz[5].fac = "Програмирование";
                vuz[5].group = 2213;
                vuz[5].dateup = new DateTime(1930, 3, 18);

                vuz[6].name = "Иванов И.И.";
                vuz[6].fac = "Програмирование";
                vuz[6].group = 2211;
                vuz[6].dateup = new DateTime(2002, 1, 6);

                vuz[7].name = "Василиса Л.А.";
                vuz[7].fac = "Дизайнер";
                vuz[7].group = 2213;
                vuz[7].dateup = new DateTime(1987, 1, 26);

                vuz[8].name = "Бомжатников М.И.";
                vuz[8].fac = "Дизайнер";
                vuz[8].group = 2212;
                vuz[8].dateup = new DateTime(2022, 1, 9);

                vuz[9].name = "Сноуден Э.Д.";
                vuz[9].fac = "Програмирование";
                vuz[9].group = 2211;
                vuz[9].dateup = new DateTime(1983, 6, 21);
            }

            void InputVuzInfo(Person[] vuz)
            {
                for (int i = 0;i < vuz.Length ;i++ )
                {
                    vuz[i] = new Person();

                    Console.WriteLine($"Студент №{i+1}");
                    Console.Write("Введите вашу фамилию и инициалы: ");
                    vuz[i].name = Console.ReadLine();

                    Console.Write("Введите название вашего факультета: ");
                    vuz[i].fac = Console.ReadLine();

                    vuz[i].group = InputNumGroup();

                    int year = InputYersUp();
                    int month = InputMonthUp();
                    int day = InputDayUp(year, month);
                    vuz[i].dateup = new DateTime(year, month, day);
                    Console.Clear();
                }
            }
            void OutputVuzInfo(Person[] vuz)
            {
                // Сортировка по имени
                for (int i = 0; i < vuz.Length; i++)
                {
                    for (int j = 0; j < vuz.Length; j++)
                    {
                        if (vuz[i].name[0] < vuz[j].name[0])
                        {
                            Person temp = vuz[i];
                            vuz[i] = vuz[j];
                            vuz[j] = temp;
                        }
                    }
                }
                // Сортировка по дате поступления
                for (int i = 0; i < vuz.Length; i++)
                {
                    for (int j = 0; j < vuz.Length; j++)
                    {
                        if (vuz[i].dateup < vuz[j].dateup)
                        {
                            Person temp = vuz[i];
                            vuz[i] = vuz[j];
                            vuz[j] = temp;
                        }
                    }
                }
                // Сортировка по группам
                for (int i = 0; i < vuz.Length; i++)
                {
                    for (int j = 0; j < vuz.Length; j++)
                    {
                        if (vuz[i].group < vuz[j].group)
                        {
                            Person temp = vuz[i];
                            vuz[i] = vuz[j];
                            vuz[j] = temp;
                        }
                    }
                }
                // Сортировка по факультетам
                for (int i = 0; i < vuz.Length; i++)
                {
                    for (int j = 0; j < vuz.Length; j++)
                    {
                        if (vuz[i].fac[0] < vuz[j].fac[0])
                        {
                            Person temp = vuz[i];
                            vuz[i] = vuz[j];
                            vuz[j] = temp;
                        }
                    }
                }
                // вывод отсартированной структуры
                for (int i = 0; i < vuz.Length; i++)
                {
                    Console.WriteLine($"{vuz[i].name.PadRight(20)}| {vuz[i].fac.PadRight(16)}| {vuz[i].group} | {vuz[i].dateup.ToShortDateString().PadRight(15)}");
                }
            }
            Person[] SortDate(Person[] vuz)
            {
                for (int i = 0; i < vuz.Length; i++)
                {
                    for (int j = 0; j < vuz.Length; j++)
                    {
                        if (vuz[i].dateup < vuz[j].dateup)
                        {
                            Person temp = vuz[i];
                            vuz[i] = vuz[j];
                            vuz[j] = temp;
                        }
                    }
                }
                return vuz;
            }
        }


        public static int InputNumGroup()
        {
            int result = -1;
            while (true)
            {
                Console.Write("Введите номер вашей группы: ");
                string digital = Console.ReadLine();
                bool check = int.TryParse(digital, out result);

                if (check == true)
                {
                    if (result < 0) Console.WriteLine("\nНомер группы неможет быть отрицательным!!!\n");
                    else break;
                }
                else Console.WriteLine("\nНомер группы должен состоять из цифр!!!\n");

            }
            return result;
        }
        public static int InputYersUp()
        {
            int year = 0;
            while (true)
            {
                Console.Write("Введите год поступления: ");
                string digital = Console.ReadLine().Trim();
                bool check = int.TryParse(digital, out year);

                if (check == true)
                {
                    if (year > DateTime.Now.Year) Console.WriteLine("\nСтудентов из будущего не учаться в нашем университете!!!\n");
                    else if (year <= 1900) Console.WriteLine("\nЗомби не учатся в нашем университете!!!\n");
                    else break;
                }
                else Console.WriteLine("\nГод должен состоять только из цифр\n");

            }
            return year;
        }
        public static int InputMonthUp()
        {
            int month;
            while (true)
            {
                Console.Write("Введите месяц поступления: ");
                string check = Console.ReadLine().Trim().ToLower();

                if      (check == "1" || check == "январь") { month = 1; break; }
                else if (check == "2" || check == "февраль") { month = 2; break; }
                else if (check == "3" || check == "март") { month = 3; break; }
                else if (check == "4" || check == "апрель") { month = 4; break; }
                else if (check == "5" || check == "май") { month = 5; break; }
                else if (check == "6" || check == "июнь") { month = 6; break; }
                else if (check == "7" || check == "июль") { month = 7; break; }
                else if (check == "8" || check == "август") { month = 8; break; }
                else if (check == "9" || check == "сентябрь") { month = 9; break; }
                else if (check == "10" || check == "октябрь") { month = 10; break; }
                else if (check == "11" || check == "ноябрь") { month = 11; break; }
                else if (check == "12" || check == "декабрь") { month = 12; break; }
                else Console.WriteLine("\nТакого месяца нету...\n");
            }
            return month;
        }
        public static int InputDayUp(int year, int month)
        {
            int day= 0;
            while (true)
            {
                Console.Write("Введите день поступления: ");
                string digital = Console.ReadLine();
                bool check = int.TryParse(digital, out day);

                if (check == true)
                {
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 && day > 0 && day <= 31) break;
                    else if (month == 4 || month == 6 || month == 9 || month == 11 && day > 0 && day <= 30) break;
                    else if (month == 2 && year %4 == 0 && day > 0 && day < 29) break;
                    else if (month == 2 && year %4 != 0 && day > 0 && day < 28) break;
                    else Console.WriteLine("\nВ этом месяце нет столько дней!!!\n");
                }
                else Console.WriteLine("Вы ввели не число!!!");
            }

            return day;
        }

        public static void ExitProgramm()
        {
            Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
    struct Person
    {
        public string name;
        public string fac;
        public int group;
        public DateTime dateup;
    }
}
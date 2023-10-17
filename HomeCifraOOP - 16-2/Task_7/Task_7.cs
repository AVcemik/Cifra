/*
        Задача № 7 Анализ логов (повышенная сложность)
Создайте программу для анализа логов. Прочитайте лог-файл, разделите
его на строки, и затем подсчитайте количество ошибок каждого типа.
Используйте Dictionary для этой задачи.
 */

string curentDirectory = Directory.GetCurrentDirectory();
string logFile = "\\log.txt";
Dictionary<string, int> count  = new Dictionary<string, int>();
string[] log = File.ReadAllLines(curentDirectory + logFile);

for (int i = 0; i < log.Length; i++)
{
    string[] lineTemp = log[i].Split(" Ошибка: ", 2);
    if (count.ContainsKey(lineTemp[1]))
    {
        count[lineTemp[1]]++;
    }
    else
    {
        count.Add(lineTemp[1], 1);
    }
}

foreach (var item in count)
{
    Console.WriteLine(item.Key + " - " + item.Value);
}
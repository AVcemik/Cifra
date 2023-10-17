/*
        Задача № 7 Анализ логов (повышенная сложность)
Создайте программу для анализа логов. Прочитайте лог-файл, разделите
его на строки, и затем подсчитайте количество ошибок каждого типа.
Используйте Dictionary для этой задачи.
 */

string curentDirectory = Directory.GetCurrentDirectory();
string logFile = "\\log.txt";
Dictionary<string, string> log  = new Dictionary<string, string>();
string[] temp = File.ReadAllLines(curentDirectory + logFile);

for (int i = 0; i < temp.Length; i++)
{
    string[] lineTemp = temp[i].Split('');
    log.Add(lineTemp[0], lineTemp[1]);
}

foreach (var item in log)
{
    Console.WriteLine(log.Keys + " - " + log.Values);
}
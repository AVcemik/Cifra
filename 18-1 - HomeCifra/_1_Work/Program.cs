// Домашнее задание.
// Тема 18. Урок 1.
// Работа со строками. Метод Split.

string[] forbiddenWords = new string[] {"слово" };    // содержащий ключевые слова, которые должны быть скрыты в предложении
string sentence = "";                            // для хранения введенного предложения

while (true)
{
    bool flag = false;
    Console.Write("Введите слово (Для завершения введите \"exit\"): ");
    string word = Console.ReadLine()!;
    word = word.Trim();

    for (int i = 0; i < forbiddenWords.Length; i++)
    {
        if (forbiddenWords[i] == word)
        {
            sentence += "(скрыто)";
            flag = true;
            break;
        }

        if (word == "exit")
        {
            flag = true;
            break;
        }
    }
    if (flag == true) break;
    sentence += word + " ";
}

Console.WriteLine("Ваше составленное предложение: " + sentence);

Console.WriteLine("\n\nНажмите любую клавишу для завершения...");
Console.ReadKey();
Environment.Exit(0);
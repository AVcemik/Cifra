// Домашнее задание. Тема 19. Урок 3.
// Практическая работа на закрепление материала.

// В качестве домашней работы нужно ДОРАБОТАТЬ игру Fizz-Buzz.

// Fizz-Buzz  – это известная игра, помогающая детям
// освоить в игровой форме правила деления.
// Участники садятся в круг, чтобы игра теоретически могла
// продолжаться бесконечно.
// Первый игрок говорит «1» и передает ход тому, кто слева.
// Каждый следующий игрок должен мысленно прибавить к предыдущему
// числу единицу и произнести либо его, либо одно из ключевых слов:
// Fizz, если число без остатка делится на три, или Buzz, если на пять.
// Если соблюдаются оба этих условия, он произносит Fizz-Buzz.
// Игрок, не сумевший сказать правильное слово, выбывает из игры.
// Последний оставшийся игрок признается победителем.
// Разработайте программу, реализующую алгоритм игры Fizz-Buzz
// применительно к  первым 100 числам.
// Каждый следующий ответ должен отображаться на новой строке.
using System.Globalization;
using System.Net.NetworkInformation;

int _count = 1;                     // Счетчик числа которое нужнопосчитать
int _gamers = 0;                    // Сколько игроков играет
int _numPlayer = 0;                 // Номер игрока (для определения кто ходит)
bool[] _player = new bool[10];      // номер массива+1 номер игрока true игрок в игре false игрок не играет
for (int i = 0; i < _player.Length; i++)
{
    _player[i] = false;
}
Help();
while (true)        // Цикл через try catch что бы принудительно заставить ввести верное кол-во игроков без вылета программы
{
    Console.Write("Укажите кол-во игроков: ");
    bool check = false;
    try
    {
        _gamers = int.Parse(Console.ReadLine()!);
        if (_gamers >= 2 && _gamers <= 10)
        {
            for (int i = _gamers, j = 0; i > 0; i--, j++)
            {
                _player[j] = true;
            }
            check = true;
        }
        else Console.WriteLine("ОШИБКА!!! неверно указано кол-во игроков (игроков может быть от 2 до 10)");
    }
    catch (Exception)
    {
        Console.WriteLine("ОШИБКА!!! неверно заполнено поле (можно указывать только цифры и только от 2 до 10)");
    }
    if (check == true) break;
}

Console.WriteLine();
Console.WriteLine($"Играет {_gamers} игроков");
Console.WriteLine();

while (true)            // Основной цикл (тело игры)
{
    Console.WriteLine("-----------------------------------------");
    Console.Write($"Отвечает игрок №{_numPlayer + 1} - ");
    string _response = Console.ReadLine()!;
    CheackResult(_count, _response, _numPlayer);            // Проверяю правильность ответа игрока
    _gamers = CheackPlayer(_player);                        // Проверка кол-во игроков
    if (_gamers == 1) break;                                // Остался один игрок

    _count++;
    if (_count == 101) break;                               // Последний ход по счетчику
    _numPlayer = CheackTurnPlayer(_numPlayer, _player);     // Проверка хода игрока (очередность хода)
}

string winner = $"| {Result(_player)} ПОБЕДИЛ!!!! |";        // Выявляем победителей
string razdelitel = "";
Console.WriteLine();
for (int i = 0; i < winner.Length; i++)
{
    razdelitel += "-";
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\t{razdelitel}\n\t{winner}\n\t{razdelitel}");
Console.ResetColor();

void CheackResult(int count, string response, int numPlayer)
{
    if (count % 3 == 0 && count % 5 == 0)
    {
        if (response == "Fizz-Buzz")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Правильно");
            Console.ResetColor();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
            Console.ResetColor();
            Console.WriteLine("Правельный ответ \"Fizz-Buzz\"");
            _player[numPlayer] = false;
        }
    }
    else if (count % 3 == 0)
    {
        if (response == "Fizz")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Правильно");
            Console.ResetColor ();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
            Console.ResetColor();
            Console.WriteLine("Правельный ответ \"Fizz\"");
            _player[numPlayer] = false;
        }
    }
    else if (count % 5 == 0)
    {
        if (response == "Buzz")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Правильно");
            Console.ResetColor();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
            Console.ResetColor();
            Console.WriteLine("Правельный ответ \"Buzz\"");
            _player[numPlayer] = false;
        }
    }
    else
    {
        if (int.Parse(response) == count)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Правильно");
            Console.ResetColor();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
            Console.ResetColor();
            Console.WriteLine($"Правельный ответ \"{count}\"");
            _player[numPlayer] = false;
        }
    }
}
int CheackPlayer(bool[] player)
{
    int temp = 0;
    for (int i = 0; i < player.Length; i++)
    {
        if (player[i] == true) temp++;
    }
    return temp;
}
int CheackTurnPlayer(int numPlayer, bool[] player)
{
    int j = player.Length;
    for (int i = 0; i < 9; i++)
    {
        numPlayer++;
        if (j == numPlayer) numPlayer = 0;

        if (player[numPlayer] == true) return numPlayer;
    }
    return numPlayer;
}
string Result(bool[] player)
{
    string result = "";
    bool flag = false;
    for (int i = 0; i < player.Length; i++)
    {
        if (player[i] == true && flag == false)
        {
            result += $" Игрок №{i+1}";
            flag = true;
        }
        else if (player[i] == true)
        {
            result += $", Игрок №{i+1}";
        }
    }
    return result;
}
void Help()
{
    Console.WriteLine(@"Fizz-Buzz  – это известная игра, помогающая детям
освоить в игровой форме правила деления.
Участники садятся в круг, чтобы игра теоретически могла
продолжаться бесконечно.
Первый игрок говорит «1» и передает ход тому, кто слева.
Каждый следующий игрок должен мысленно прибавить к предыдущему
числу единицу и произнести либо его, либо одно из ключевых слов:
Fizz, если число без остатка делится на три, или Buzz, если на пять.
Если соблюдаются оба этих условия, он произносит Fizz-Buzz.
Игрок, не сумевший сказать правильное слово, выбывает из игры.
Последний оставшийся игрок признается победителем.

Кол-во игроков от 2 до 10");
}
// Домашнее задание. Тема 19. Урок 1.
// Практическая работа на закрепление материала.

// В качестве домашней работы нужно разработать игру Fizz-Buzz.

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

int _count = 1;
int _gamers = 0;
int _numPlayer = 0;
bool[] _player = new bool[10];
for (int i = 0; i < _player.Length; i++)
{
    _player[i] = false;
}
Help();
while (true)
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
while (true)
{
    Console.WriteLine("-----------------------------------------");
    Console.Write($"Отвечает игрок №{_numPlayer + 1} - ");
    string _response = Console.ReadLine()!;
    CheackResult(_count, _response, _numPlayer);
    _gamers = CheackPlayer(_player);
    if (_gamers == 1) break;
    _count++;
    _numPlayer = CheackTurnPlayer(_numPlayer, _player);
}
Console.WriteLine();
Console.WriteLine($"Игрок №{Result(_player) + 1} ПОБЕДИЛ!!!!");

void CheackResult(int count, string response, int numPlayer)
{
    if (count % 3 == 0 && count % 5 == 0)
    {
        if (response == "Fizz-Buzz") Console.WriteLine("Правильно");

        else
        {
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
            Console.WriteLine("Правельный ответ \"Fizz-Buzz\"");
            _player[numPlayer] = false;
        }
    }
    else if (count % 3 == 0)
    {
        if (response == "Fizz") Console.WriteLine("Правильно");

        else
        {
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
            Console.WriteLine("Правельный ответ \"Fizz\"");
            _player[numPlayer] = false;
        }
    }
    else if (count % 5 == 0)
    {
        if (response == "Buzz") Console.WriteLine("Правильно");

        else
        {
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
            Console.WriteLine("Правельный ответ \"Buzz\"");
            _player[numPlayer] = false;
        }
    }
    else
    {
        if (int.Parse(response) == count) Console.WriteLine("Правильно");

        else
        {
            Console.WriteLine($"Неверно!!! Игрок №{numPlayer + 1} выбывает");
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
    for (int i = 0; i < 8; i++)
    {
        numPlayer++;
        if (j == numPlayer) numPlayer = 0;

        if (player[numPlayer] == true) return numPlayer;
    }
    return numPlayer;
}
int Result(bool[] player)
{
    int result = -1;
    for (int i = 0; i < player.Length; i++)
    {
        if (player[i] = true)
        {
            result = i;
            break;
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
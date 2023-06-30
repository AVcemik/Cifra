
string _player1 = "Игрок 1";
string _player2 = "Игрок 2";
string _player3 = "Игрок 3";

Console.WriteLine("\t\t\tСВОЯ ИГРА");
startMenu();

Jeopardy();

void Jeopardy()
{
    while (true)
    {
        
    }
}

void GamePole()
{

}
void startMenu()
{
    Console.WriteLine("Стартовое меню:");
    Console.WriteLine("1 - Начать игру");
    Console.WriteLine("2 - Правила (рекомендуем ознакомить)");
}
void QuestingAnswer(int count)
{
        Themes[] themes = new Themes[6];
        if (count == 1)
        {
        themes[0].Count = 1;
        themes[0].Theme = "";

        QuestAnswer[] questAnswer = new QuestAnswer[5];
        questAnswer[0].Price = 200;
        questAnswer[0].Questing = "";
        questAnswer[0].Answer = "";
        questAnswer[0].Player = "-";

        
        }
}

public struct Themes
{
    public int Count;
    public string Theme;
    public QuestAnswer Questing;

}
public struct QuestAnswer
{
    public int Price;
    public string Questing;
    public string Answer;
    public string Player;
}
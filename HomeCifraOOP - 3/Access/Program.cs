// Домашнее задание
// Управление доступом к членам класса

public class MobilePhone
{
    private string _name;
    private int _number;
    private decimal _money;


    public MobilePhone(string name, int number)
    {
        _name = name;
        _number = number;
        _money = 100;
    }

    ~MobilePhone()
    {
        Console.WriteLine("Абонент с номером телефона {0} был удален", _number);
    }
    public void MoneyUp(decimal money)
    {
        _money += money;
    }

    /// <summary>
    /// Оплата разговора (Тариф (стоимость за минуту) Время разговора (в секундах))
    /// </summary>
    /// <param name="tariffPrice">Стоимость за минуту</param>
    /// <param name="timeSecond">Время разговора в секундах</param>
    public void MoneyDown(decimal tariffPrice, int timeSecond)
    {
        if (_money >= tariffPrice / 60 * timeSecond)
        {
            _money = tariffPrice / 60 * timeSecond;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("У вас недостаточно средств");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public void CurrentBalance()
    {
        Console.WriteLine("На вашем счете: {0} денег", _money);
    }
}


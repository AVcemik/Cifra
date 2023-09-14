// Домашнее задание
// Управление доступом к членам класса
// Создать класс «Мобильный телефон», включающий данные элементы: номер, имя владельца,
// количество денег на счете. Функции-элементы:
// * создание и инициализация (конструктор),
// * пополнение счета(сумма – в аргументе),
// * оплата разговоров(тариф и время – в аргументе),
// * выдача сообщения об остатке средств на счете,
// * деструктор.

MobilePhone mobilePhone = new MobilePhone("Александр", "+7-012-345-67-89");
mobilePhone.MoneyDown(4, 300);
mobilePhone.MoneyUp(50);
mobilePhone.CurrentBalance();
mobilePhone.MoneyDown(4, 5300);
mobilePhone.MoneyDown(4, 1949);
mobilePhone.CurrentBalance();

public class MobilePhone
{
    private string _name;
    private string _numberPhone;
    private decimal _money;


    public MobilePhone(string name, string number)
    {
        _name = name;
        _numberPhone = number;
        _money = 100;
    }

    ~MobilePhone()
    {
        Console.WriteLine("Абонент с номером телефона {0} был удален", _numberPhone);
    }
    public void MoneyUp(decimal money)
    {
        _money += money;
        Console.WriteLine("Вы положили на счет {0} рублей", money);
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
            _money -= tariffPrice / 60 * timeSecond;
            Console.WriteLine("Вашь тариф {0} рубля минута, вы поговорили {1} секунд, стоимость разговора составила {2:F2}", tariffPrice, timeSecond, tariffPrice / 60 * timeSecond);
        }
        else
        {
            Console.WriteLine("Вы хотели поговорить {0} секунд", timeSecond);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("У вас недостаточно средств");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public void CurrentBalance()
    {
        if (_money >= 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("На вашем счете: {0:F2} рублей", _money);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("На вашем счете: {0:F2} рублей", _money);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

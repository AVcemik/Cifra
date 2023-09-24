/*
    Создать класс «Вагон поезда дальнего следования», включающий данные-элементы: 
    номер вагона, класс вагона, количество мест. Функции-элементы:
        * создание и инициализация (конструктор),
        * количество пассажиров, вышедших на промежуточной станции (в аргументе),
        * количество билетов, проданных на промежуточной станции (в аргументе)
        * выдача сообщения о количестве свободных мест,
        * деструктор.
 */


Train train = new(164,"Стандарт",80);
train.upPasseger(50);
train.downPassager(23);
train.NumberOfAvailableSeats();
Console.WriteLine("Кол-во проданных билетов на промежуточных станциях: {0}", train.TicketCountPromejutStation);



class Train
{
    private int _number;
    private string _grade;
    private int _seatCount;
    private int _currentCount;
    private int _ticketCountPromejutStation;

    public int TicketCountPromejutStation
    {
        get
        {
            return _ticketCountPromejutStation;
        }
    }

    public Train(int number, string grade, int seatCount)
    {
        _number = number;
        _grade = grade;
        _seatCount = seatCount;
        _currentCount = seatCount;
    }
    public Train(int number, string grade, int seatCount, int countPassager)
    {
        _number = number;
        _grade = grade;
        _seatCount = seatCount;
        if (seatCount >= countPassager)
        {
            _currentCount = seatCount - countPassager;
        }
        else
        {
            _currentCount = seatCount;
            Console.WriteLine("Вагон заполнен, остальные пассажиры не влезли");
        }
    }
    ~Train()
    {
        Console.WriteLine(_number + "Вагон утилизирован!!!");
    }

    public void downPassager(int count)
    {
        if (_currentCount + count <= _seatCount)
        {
            _currentCount += count;
        }
        else
        {
            Console.WriteLine("В вагоне нет столько пассажиров!!!");
        }
    }
    public void upPasseger(int count)
    {
        if (_currentCount >= count)
        {
            _currentCount -= count;
            _ticketCountPromejutStation += count;
        }
        else
        {
            count = _currentCount;
            _currentCount -= count;
            _ticketCountPromejutStation += count;
            Console.WriteLine("Вагон полностью заполнен, в вагон влезло {0} пассажиров", count);
        }
    }
    public void NumberOfAvailableSeats()
    {
        Console.WriteLine("Кол-во свободных мест: {0}", _currentCount);
    }
}
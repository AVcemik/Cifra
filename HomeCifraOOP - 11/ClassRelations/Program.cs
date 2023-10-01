/*
    Домашняя работа
    Задача на взаимодействие между классами. Разработать систему «Автобаза». 
    Диспетчер распределяет заявки на Рейсы между Водителями и назначает для этого Автомобиль. 
    Водитель может сделать заявку на ремонт. Диспетчер может отстранить Водителя от работы. 
    Водитель делает отметку о выполнении Рейса и состоянии Автомобиля.
 */
Dispatcher bogdan = new Dispatcher("Богдан");
Driver cemik = new Driver("Александр");
Driver basenka = new Driver("Елена");
Race race1 = new Race("Рейс №1");
Race race2 = new Race("Рейс №2");
Car lada = new Car("Лада");
Car mercedes = new Car("Мерседес");

bogdan.Race = race1;
bogdan.Race.Driver = cemik;
bogdan.Race.Car = lada;

bogdan.Race = race2;
bogdan.Race.Driver = basenka;
bogdan.Race.Car = mercedes;

bogdan.Driver = basenka;
bogdan.Driver.Status = false;

cemik.Car.Remont = true;

cemik.Car.Status = "Отличное";
cemik.Race.Finish = true;



Console.WriteLine("{0}\nВодитель: {1}\nАвтомобиль: {2}", race1.Request, race1.Driver.Name, race1.Car.Name);
Console.WriteLine();
Console.WriteLine("{0}\nВодитель: {1}\nАвтомобиль: {2}", race2.Request, race2.Driver.Name, race2.Car.Name);



class Dispatcher
{
    private string _name { get; set;}
    //public Race Race { get; set; }
    public Driver Driver { get; set; }
    public Dispatcher(string name)
    {
        _name = name;
    }
    public Dispatcher()
    {

    }
    public void RaceDriveRCar(Race race, Driver driver)
    {
        
    }
}
class Driver
{
    public string Name { get; set; }
    public bool Status { get; set; }
    public Car Car { get; set; }
    public Race Race { get; set; }
    public Driver(string name)
    {
        Name = name;
        Status = true;
    }
}
class Car
{
    public string Name { get; set; }
    public bool Remont { get; set; }
    public string Status { get; set; }

    public Car(string name)
    {
        Name = name;
        Remont = false;
    }
}

class Race : Dispatcher
{
    internal string Request { get; set; }
    public Driver Driver { get; set; }
    public Car Car { get; set; }
    public bool Finish { get; set; }

    public Race(string request)
    {
        Request = request;
        Finish = false;
    }

}


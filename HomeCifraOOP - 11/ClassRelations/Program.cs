/*
    Домашняя работа
    Задача на взаимодействие между классами. Разработать систему «Автобаза». 
    Диспетчер распределяет заявки на Рейсы между Водителями и назначает для этого Автомобиль. 
    Водитель может сделать заявку на ремонт. Диспетчер может отстранить Водителя от работы. 
    Водитель делает отметку о выполнении Рейса и состоянии Автомобиля.
 */

enum Condition
{
    bad,
    well,
    good,
    exelent
}
enum Status
{
    onWork,
    offWork,
    onVacation
}
//Dispatcher bogdan = new Dispatcher("Богдан");
//Driver cemik = new Driver("Александр");
//Driver basenka = new Driver("Елена");
//Race race1 = new Race("Рейс №1");
//Race race2 = new Race("Рейс №2");
//Car lada = new Car("Лада");
//Car mercedes = new Car("Мерседес");

//bogdan.Race = race1;
//bogdan.Race.Driver = cemik;
//bogdan.Race.Car = lada;

//bogdan.Race = race2;
//bogdan.Race.Driver = basenka;
//bogdan.Race.Car = mercedes;

//bogdan.Driver = basenka;
//bogdan.Driver.Status = false;

//cemik.Car.Remont = true;

//cemik.Car.Status = "Отличное";
//cemik.Race.Finish = true;



//Console.WriteLine("{0}\nВодитель: {1}\nАвтомобиль: {2}", race1.Request, race1.Driver.Name, race1.Car.Name);
//Console.WriteLine();
//Console.WriteLine("{0}\nВодитель: {1}\nАвтомобиль: {2}", race2.Request, race2.Driver.Name, race2.Car.Name);



class Dispatcher
{
    // Распределение рейса
    public void TripDistribution(Driver driver, Trip trip)
    {

    }
    
    public void FireDriver(Driver driver)
    {

    }
}
class Driver
{
    public string Name { get; set; }
    public Status CurrentStatus { get; set; }

    // Водитель делает заявку на ремонт
    public void SetAnOrder(Trip trip)
    {

    }

    public void MarkTripAsOvered(Trip trip)
    {

    }
    
}
class Car
{
    public string Mark { get; set; }
    public long Number { get; set; }
    public Condition Condition { get; set; }

    public void SetCondition(Condition newCondition)
    {
        Condition = newCondition;
    }
}

    

class Trip
{
    public long TripNumber { get; set; }
    public DateTime TripStartTime { get; set; }
    public DateTime TripEndtTime { get; set; }
    public string TripDescription { get; set; }
}


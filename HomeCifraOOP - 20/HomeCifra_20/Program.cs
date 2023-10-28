using System.Diagnostics.CodeAnalysis;

Animals<Animal> priut = new Animals<Animal>();

priut.AddAnimal(new Animal { NickName = "Барсик", Breed = "Кот", AcceptanceDate = DateTime.Now, Age = 3 });
priut.AddAnimal(new Animal { NickName = "Шарик", Breed = "Собака", AcceptanceDate = DateTime.Now, Age = 5 });

List<Animal> animals = priut.GetAnimals();

foreach (Animal animal in animals)
{
    Console.WriteLine($"Кличка: {animal.NickName}, Порода: {animal.Breed}, Дата поступления: {animal.AcceptanceDate}, Возраст: {animal.Age}");
}

Animal foundAnimal = priut.GetNamePoId(1);
if (foundAnimal != null)
{
    Console.WriteLine($"Найдено животное с кличкой {foundAnimal.NickName}");
}
else
{
    Console.WriteLine("Животное не найдено");
}


public class Animal : IListAnimal
{
    private static int count = 1;
    public int Id { get; set; }
    public string NickName { get; set; }
    public string Breed {  get; set; }
    public DateTime AcceptanceDate {  get; set; }
    public int Age { get; set; }
    public Animal()
    {
        Id = count;
        count++;
    }
}

public interface IListAnimal
{
    public int Id { get; set; }
}
public class Animals<T> where T : IListAnimal
{
    private List<T> animals = new List<T>();

    public void AddAnimal(T animal)
    {
        animals.Add(animal);
    }

    public List<T> GetAnimals()
    {
        return animals;
    }

    public T GetNamePoId(int id)
    {
        return animals.Find(animal => animal.Id == id);
    }
}
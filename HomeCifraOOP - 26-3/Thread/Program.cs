using System;

namespace Thread_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Thread thread_1 = new (Print);
            Thread thread_2 = new (Print);
            Thread thread_3 = new (Print);
            
            thread_1.Start("Строка");
            thread_2.Start(new Person());
            thread_3.Start(new CustomArray(5));
        }
        public static void Print(object? message)
        {
            if(message is Person)
            {
                Person personMessage = (Person)message;
                PrintPersonData(personMessage);
            }
            else if (message is CustomArray)
            {
                CustomArray customArrayMessage = (CustomArray)message;
                PrintValue(customArrayMessage);
            }
            else if (message is string)
            {
                Console.WriteLine(message);
            }
            else
            {
                throw new Exception("Передан не подходящий объект");
            }
        }

        public static void PrintPersonData(Person person)
        {
            person.Name = "Александр";
            person.Age = 35;
            Console.WriteLine($"Имя: {person.Name} \nВозраст: {person.Age}");
        }

        public static void PrintValue(CustomArray array)
        {
            Random rnd = new ();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }

    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }

    public class CustomArray
    {
        private double[] _data;
        public int Length { get { return _data.Length; } }
        public double this[int index] 
        {
            get 
            { 
                return _data[index]; 
            }
            set 
            { 
                _data[index] = value; 
            }
        }
        public CustomArray(int length) 
        {
            _data = new double[length];
        }
    }
}
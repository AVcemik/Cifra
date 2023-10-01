/*
                    Объектно ориентированное программирование на C#
                    Тема 16. Урок 1. Домашнее задание. Коллекции.

1. Массивы (Arrays): Создайте массив целых чисел и наполните его несколькими значениями от -10 до 10.
2. Списки (List): Создайте список строк и добавьте в него несколько элементов произвольных имен.
3. Стек (Stack): Инициализируйте стек целых чисел и добавьте несколько элементов.
4. Продемонстрируйте операции добавления и извлечения элементов из стека.
5. Очередь (Queue): Создайте очередь строк и добавьте в нее элементы.
6. Словари (Dictionary): Создайте словарь, связывая строки с целыми числами (например, слова и их длины).
7. Множества (HashSet, SortedSet): Создайте множество целых чисел, добавьте в него несколько элементов.
8. Коллекции для работы с ключами и значениями (KeyValuePair, KeyValuePair<TKey, TValue>): 
Создайте коллекцию KeyValuePair, связывая имена и возраст. 
Добавьте несколько элементов и покажите, как работать с этими парами.
*/


// Задача №1
int[] masiv = new int[10] { 5, 9, 3, -10, 6, -7, 2, -2, -4, 3 };

// Задача №2
List<string> name = new List<string>() 
{ 
    "Александр",
    "Денис",
    "Елена",
    "Милана",
    "Сергей"
};

// Задача №3
Stack<int> stack = new Stack<int>(masiv);

// Задача №4
stack.Push(30);
Console.WriteLine("Извлечение 3 элементов из стека: {0}, {1}, {2}", stack.Pop(), stack.Pop(), stack.Pop());

// Задача %5
Queue<string> queue = new Queue<string>();
queue.Enqueue("hello");
queue.Enqueue("world");

// Задача №6
Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add(name[0], InputDictionary(name[0]));
dictionary.Add(name[1], InputDictionary(name[1]));
dictionary.Add(name[2], InputDictionary(name[2]));

// Задача №7
HashSet<int> hashSet = new HashSet<int>();
hashSet.Add(3);
hashSet.Add(7);
hashSet.Add(1);
hashSet.Add(5);

SortedSet<int> sotedSet = new SortedSet<int>();
sotedSet.Add(3);
sotedSet.Add(7);
sotedSet.Add(1);
sotedSet.Add(5);

// Задача №8
List<KeyValuePair<string, int>> people = new List<KeyValuePair<string, int>>();
people.Add(new KeyValuePair<string, int>("Александр", 35));
people.Add(new KeyValuePair<string, int>("Елена", 30));
Console.WriteLine("\nЧеловек №1");
Console.WriteLine(people[0]);
Console.WriteLine("\nЧеловек №2\nИмя: " + people[1].Key + "\nВозраст: " + people[1].Value);


// Функция для подсчета кол-ва букв в слове
int InputDictionary(string word)
{
    int result = -1;
    result = word.Length;
    return result;
}



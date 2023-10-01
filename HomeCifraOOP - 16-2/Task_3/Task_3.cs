/*
            Задача №3. Проверка на уникальность:
Напишите функцию, которая принимает массив и возвращает true, 
если все элементы в массиве уникальны, и false в противном случае.
Используйте HashSet для решения этой задачи.
 */

int[] masivTrue = new int[] {1, 2, 3, 4, 5 };
int[] masivFalse = new int[] { 1, 2, 2, 5, 5 };

Console.WriteLine("masivTrue: " + CheckUnique(masivTrue));
Console.WriteLine("masivFalse: " + CheckUnique(masivFalse));
bool CheckUnique(int[] masiv)
{
    HashSet<int> hashSet = new HashSet<int>();

    foreach (int item in masiv)
    {
        if (!hashSet.Add(item))
        {
            return false;
        }
    }
    return true;
}
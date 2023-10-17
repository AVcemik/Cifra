var lst = Console.ReadLine().Split().Select(int.Parse).ToList();
int K = lst[0];
int counte = 0;
for (int i = 1; i != K + 1; i++)
{
    counte += lst[i];
}
K--;
Console.WriteLine(counte - K);
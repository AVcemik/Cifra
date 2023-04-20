using _11_227;


// 11.227.
// Имеется информация о количестве осадков, выпавших за каждый день месяца,
// и о температуре воздуха в эти дни. Определить, какое количество осадков выпало
// в виде снега и какое — в виде дождя.
// (Считать, что идет дождь, если температура воздуха выше 0 С.)


double[,] fallout = new double[30,2];
Random r = new Random();

for (int i = 0; i < fallout.GetLength(0); i++)
{
    for (int j = 0; j < fallout.GetLength(1); j++)
    {
        fallout[i, j] = r.NextDouble() + r.Next(-10, 10);
    }
}

for (int i = 0; i < fallout.GetLength(0); i++)
{
    for (int j = 0; j < fallout.GetLength(1); j++)
    {
        Console.Write($"{fallout[i,j]:F2} ");
    }
    Console.WriteLine($"");
}












AddFunc.Exit();
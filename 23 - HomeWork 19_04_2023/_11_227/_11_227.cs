using _11_227;


// 11.227.
// Имеется информация о количестве осадков, выпавших за каждый день месяца,
// и о температуре воздуха в эти дни. Определить, какое количество осадков выпало
// в виде снега и какое — в виде дождя.
// (Считать, что идет дождь, если температура воздуха выше 0 С.)


double[] fallout = new double[30];
Random r = new Random();

for (int i = 0; i < fallout.Length; i++)
{
    fallout[i] = r.NextDouble();
}
foreach (int i in fallout) Console.Write($"{i:F2} ");












AddFunc.Exit();
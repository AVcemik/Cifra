using _11_227;


// 11.227.
// Имеется информация о количестве осадков, выпавших за каждый день месяца,
// и о температуре воздуха в эти дни. Определить, какое количество осадков выпало
// в виде снега и какое — в виде дождя.
// (Считать, что идет дождь, если температура воздуха выше 0 С.)


double[,] _fallout = new double[30,3];
int _snow, _rain;

AddFunc.FillMass(_fallout, out _snow, out _rain);
AddFunc.OutputMass(_fallout);

Console.WriteLine($"\nКол-во снега: {_snow} \nКол-во дождя: {_rain}");

AddFunc.Exit();
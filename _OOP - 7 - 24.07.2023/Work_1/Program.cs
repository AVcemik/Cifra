using Work_1;
using Work_1.China;
using Work_1.Russia;
using Work_1.UAR;

// Домашняя работа
// 1.	Разработать приложение, в котором бы сравнивалось
// население трёх столиц из разных стран. Причём страна
// бы обозначалась пространством имён, а город — классом
// в данном пространстве.


Moscow moscow = new Moscow(12500000);
Pekin pekin = new Pekin(21500000);
Pretoria pretoria = new Pretoria(1100000);

Console.WriteLine();

moscow.PrintPopulation();
pekin.PrintPopulation();
pretoria.PrintPopulation();

Console.WriteLine();

AddFunc.Printmax(moscow, pekin, pretoria);
AddFunc.Printmin(moscow, pekin, pretoria);
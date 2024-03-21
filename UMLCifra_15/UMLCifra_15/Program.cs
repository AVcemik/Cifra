using UMLCifra_15;

Architect architect = new();
Builder builder = new();
Electrician electrician = new();
Decorator decorator = new();

architect.RegisterNext(builder);
builder.RegisterNext(electrician);
electrician.RegisterNext(decorator);

Console.WriteLine(architect.ApproveExpense("Покраска").GetDescription());
Console.WriteLine(architect.ApproveExpense("Монтаж розеток").GetDescription());
Console.WriteLine(architect.ApproveExpense("Уложитькровлю").GetDescription());
Console.WriteLine(architect.ApproveExpense("Оформить чертеж").GetDescription());
Console.WriteLine(architect.ApproveExpense("Поклеить обои").GetDescription());
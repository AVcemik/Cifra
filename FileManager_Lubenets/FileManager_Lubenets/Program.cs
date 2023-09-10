// Консольный файловый менеджер

using FileManager_Lubenets;


AdditionalFunctional.SetSizeConsole();

Draw.DrawWindow(0, 18);
Draw.DrawWindow(20, 8);
Draw.DrawWindow(30, 1);
Draw.DrawInputCommandField(AdditionalFunctional.CurrentDirectory);

Console.ReadKey();



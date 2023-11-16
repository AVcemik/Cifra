using OfficeOpenXml;
using System.Security.Cryptography;

string path = Directory.GetCurrentDirectory() + "\\Список Клиентов.xlsx";

if (File.Exists(path))
    File.Delete(path);


Client[] client =
{
    new("Иван", "Иванов", "ivan@example.com"),
    new("Петр", "Петров", "peter@example.com"),
    new("Мария", "Сидорова", "maria@example.com"),
    new("Анна", "Кузнецова", "anna@example.com"),
    new("Алексей", "Смирнов", "alex@example.com"),
    new("Наталья", "Васильева", "natalia@example.com"),
    new("Сергей", "Морозов", "sergey@example.com"),
    new("Ольга", "Павлова", "olga@example.com"),
    new("Денис", "Жуков", "denis@example.com"),
    new("Екатерина", "Макарова", "ekaterina@example.com")
};

ExcelPackage newBook = new(path);
ExcelWorksheet currentSheet = newBook.Workbook.Worksheets.Add("Клиенты");


currentSheet.Cells["A1:C10"].AutoFilter = true;
currentSheet.Cells["A1:C1"].Style.Font.Bold = true;
currentSheet.Cells[1, 1].Value = "Имя";
currentSheet.Cells[1, 2].Value = "Фамилия";
currentSheet.Cells[1, 3].Value = "E-mail";
for (int i = 0, m=2; i < client.Length; i++, m++)
{
    currentSheet.Cells[m, 1].Value = client[i].FirstName;
    currentSheet.Cells[m, 1].AutoFitColumns();
    currentSheet.Cells[m, 2].Value = client[i].SecondName;
    currentSheet.Cells[m, 2].AutoFitColumns();
    currentSheet.Cells[m, 3].Value = client[i].Email;
    currentSheet.Cells[m, 3].AutoFitColumns();
}
currentSheet.Column(1).Width += 7;
currentSheet.Column(2).Width += 7;
currentSheet.Column(3).Width += 7;

newBook.Save();


class Client
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Email { get; set; }
    public Client(string firstName, string secondName, string email)
    {
        FirstName = firstName;
        SecondName = secondName;
        Email = email;
    }
}
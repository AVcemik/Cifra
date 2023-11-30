using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.ComponentModel;
using System.Drawing;

ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

// Укажите год, для которого нужно создать календарь
int year = 2023;

int firstSundayInYear = FirstSundayInYear(); // Определяю какой день в году будет первым выходным
string pathCalendary = Directory.GetCurrentDirectory() + $"\\Календарь_{year}.xlsx";
if (File.Exists(pathCalendary))
    File.Delete(pathCalendary);

ExcelPackage newBook = new ExcelPackage(pathCalendary);
ExcelWorksheet currentShet = newBook.Workbook.Worksheets.Add($"Календарь {year}");
Calendary[] calendary = Calendary.CreateCalendaryYear(year);


ClearFieldBorder(); // Очищаю поле от бордюров
FillNameMonth(2);   // Наполняю таблицу месяцами
FillDay(2,3);       // Наполняю таблицу днями
AddStyle();         // Добавляем немного стилизации
newBook.Save();

int FirstSundayInYear() // Расчет первого воскресенья года
{
    int firstSundayInYear = -1;
    int firstDayWeek = ((int)new DateTime(year).DayOfWeek);
    for (int i = 1; i <= 7; i++)
    {
        if (firstDayWeek == 1)
        {
            firstSundayInYear = i;
            break;
        }
        else firstDayWeek--;
    }
    if (firstSundayInYear == -1) throw new Exception("Неверный расчет выходных дней");
    return firstSundayInYear;
}
void ClearFieldBorder()
{
    for (int row = 1; row < 51; row++)
    {
        for (int column = 1; column < 51; column++)
        {
            currentShet.Cells[row, column].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.White);
        }
    }
}
void FillNameMonth(int row)
{
    for (int i = 0; i < calendary.Length; i++, row++)
    {
        currentShet.Cells[row, 2].Value = calendary[i].NameMonth;
        currentShet.Cells.AutoFitColumns(2);
        currentShet.Column(2).Width += 5;
        currentShet.Cells[row, 2].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);
    }
}
void FillDay(int row, int column)
{
    int count = column;
    for (int month = 0; month < calendary.Length; month++)
    {
        for (int j = 0, days = 1; j <= 31; j++, days++)
        {
            currentShet.Cells[row, column].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Gray);
            if (firstSundayInYear == 8)
                firstSundayInYear = 1;
            currentShet.Cells[row, column].Value = days;
            if (firstSundayInYear == 1 || firstSundayInYear == 7)
            {
                currentShet.Cells[row, column].Style.Fill.PatternType = ExcelFillStyle.Solid;
                currentShet.Cells[row, column].Style.Fill.BackgroundColor.SetColor(Color.LightCoral);
                currentShet.Cells[row, column].Style.Font.Bold = true;
            }
            firstSundayInYear++;
            if (days == calendary[month].Days) break;
            column++;
        }
        column = count;
        row++;
    }
}
void AddStyle()
{
    currentShet.Cells["B2:B13"].Style.Font.Bold = true;
    currentShet.Cells["B2:B13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
    currentShet.Cells["B2:B13"].Style.Fill.BackgroundColor.SetColor(Color.LightCyan);
    currentShet.Cells["A1:AG13"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
    currentShet.Cells["B2:AG13"].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);

    for (int i = 3; i < 34; i++)
    {
        currentShet.Column(i).Width = 4;
        currentShet.Column(i + 37).Width = 10;
    }
    currentShet.Column(1).Width = 10;
    currentShet.Row(1).Height = 50;

}

class Calendary // Класс представляющий описание месяца и имеющий метод возврата массива месяцев == году
{
    public string? NameMonth { get; set; }
    public int Days { get; set; }

    public Calendary(int year) // Конструктор создание массива свойст месяца == году
    {
        CreateCalendaryYear(year);
    }
    public Calendary(string month, int days) // Конструктор создание свойст месяца
    {
        NameMonth = month;
        Days = days;
        
    }
    public static Calendary[] CreateCalendaryYear(int year)
    {
        int quantityDaysFebruar = 28;
        if (year % 4 == 0)
            quantityDaysFebruar = 29;

            Calendary[] calendary =
        {
            new("Январь", 31),
            new("Февраль", quantityDaysFebruar),
            new("Март", 31),
            new("Апрель", 30),
            new("Май", 31),
            new("Июнь", 30),
            new("Июль", 31),
            new("Август", 31),
            new("Сентябрь", 30),
            new("Октябрь", 31),
            new("Ноябрь", 30),
            new("Декабрь", 31)
        };
        return calendary;
    }
}
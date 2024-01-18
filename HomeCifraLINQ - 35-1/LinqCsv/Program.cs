using CsvHelper;
using CsvHelper.Configuration;
using LinqCsv;
using System.Globalization;

string fullPath = Directory.GetCurrentDirectory() + "\\inventoryControl.csv";
List<Good> listItem = new();

using (StreamReader reader = new StreamReader(fullPath))
{
    CsvReader csvReader = new(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
    listItem = csvReader.GetRecords<Good>().ToList();
}

var result = listItem.Where(i => i.Quantity % 2 == 0);

foreach (Good item in result)
{
    
    Console.WriteLine($"{item.Name} - {item.Quantity} - {item.Price} - {item.Description}");
} 
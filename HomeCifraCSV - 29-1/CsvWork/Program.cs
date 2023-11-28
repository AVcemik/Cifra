using CsvHelper;
using CsvHelper.Configuration;
using CsvWork;
using System.Globalization;

StreamWriter streamWriter = new("Output.csv");

CsvWriter csvWriter = new(streamWriter, new CsvConfiguration(CultureInfo.InvariantCulture));

List<Person> records = new()
{
    new Person {Name = "Александр", Age = 36},
    new Person {Name = "Елена", Age = 25},
};

csvWriter.WriteRecords(records);

streamWriter.Close();

records.Clear();

StreamReader streamReader = new("Output.csv");

CsvReader csvReader = new(streamReader, new CsvConfiguration(CultureInfo.InvariantCulture));

records = csvReader.GetRecords<Person>().ToList();

streamReader.Close();

foreach (Person person in records)
{
    Console.WriteLine("{0} - {1}", person.Name, person.Age);
}
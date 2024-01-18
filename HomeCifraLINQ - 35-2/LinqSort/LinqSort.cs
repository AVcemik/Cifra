using CsvHelper;
using CsvHelper.Configuration;
using LinqSort;
using System.Globalization;

string fullPath = Directory.GetCurrentDirectory() + "\\Movies.csv";
List<Movie> movies = new();

using (StreamReader reader = new(fullPath))
{
    CsvReader csvReader = new(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
    movies = csvReader.GetRecords<Movie>().ToList();
}

var result = movies.OrderByDescending(m => m.Year);

foreach (var movie in result)
{
    Console.WriteLine($"номер: {movie.Id}\t Дата: {movie.Year}\t Жанр:{movie.Genre}\t Оценка: {movie.Graduate}\t Название: {movie.Name}");
}


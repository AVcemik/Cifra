using CsvHelper;
using HomeCifraWPF___93.Models;
using System.IO;

namespace HomeCifraWPF___93.Service
{
    public class SCVFileReader
    {
        public static List<Movie> ReadFile()
        {
            List<Movie> movies = new List<Movie>();

            using (StreamReader reader = new StreamReader("Movies.csv"))
            {
                CsvReader csvReader = new(reader, System.Globalization.CultureInfo.InvariantCulture);

                movies.AddRange(csvReader.GetRecords<Movie>().ToList());
            }

            return movies;
        }
    }
}

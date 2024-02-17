using CsvHelper;
using CsvHelper.Configuration;
using HomeCifraWPF___96.Models;
using System.Globalization;
using System.IO;

namespace HomeCifraWPF___96.Services
{
    public static class CSVOperation
    {
        public static void SaveCSVFile(List<Product> products)
        {
            using (StreamWriter write = new("Список продуктов.csv"))
            {
                CsvWriter csvWriter = new(write, CultureInfo.InvariantCulture);

                csvWriter.WriteRecords(products);
            }
        }
    }
}

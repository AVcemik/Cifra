using CsvHelper;
using OfflineShop.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace OfflineShop.Services
{
    public class CsvFileReader
    {
        private static string _filePath = "Data\\ClothProducts.csv";
        public static ObservableCollection<Product> GetCsvFile()
        {
            List<Product> products = new List<Product>();

            using (StreamReader reader = new StreamReader(_filePath))
            {
                CsvReader csvReader = new(reader, CultureInfo.InvariantCulture);

                products = csvReader.GetRecords<Product>().ToList();
            }

            ObservableCollection<Product> result = new ObservableCollection<Product>();

            foreach (Product product in products)
            {
                result.Add(product);
            }
            return result;
        }
    }
}

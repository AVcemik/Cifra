using CsvHelper;
using System.Globalization;


namespace DataBase_from_CSV
{
    public static class CsvOperation
    {
        private static string _path = "iris.csv";
        public static List<Iris> ReadCsvFileIris()
        {
            List<Iris> list = new();
            using (StreamReader reader = new(_path))
            {
                CsvReader csvReader = new(reader, CultureInfo.InvariantCulture);
                list = csvReader.GetRecords<Iris>().ToList();
            }

            return list;
        }
    }
}

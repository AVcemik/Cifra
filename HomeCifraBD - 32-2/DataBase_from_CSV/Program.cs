namespace DataBase_from_CSV
{
    internal class Program
    {
        private static string _pathBd = Directory.GetCurrentDirectory() + "\\IrisesDatabase.db";
        private static string _pathDoc = Directory.GetCurrentDirectory() + "\\iris.docx";
        static void Main(string[] args)
        {
            if (File.Exists(_pathBd))
                File.Delete(_pathBd);
            if (File.Exists(_pathDoc))
                File.Delete(_pathDoc);

            List<Iris> listBd = new();
            List<Iris> listCsv = CsvOperation.ReadCsvFileIris();

            using (DataBaseContext context = new())
            {
                foreach (var item in listCsv)
                {
                    var addIris = new Iris(item.SepalLength, item.SepalWidth, item.PetalLength, item.PetalWidth, item.Variety);
                    context.Irises.Add(addIris);
                }
                context.SaveChanges();
            }
            Console.WriteLine("Данные успешно добавлены в БД");

            //----------------------------------------------------------------------------------------------

            using (DataBaseContext context = new())
            {
                listBd = context.Irises.ToList();
            }

            WordOperation.CreateTableWordBd(listBd);
        }
    }
}
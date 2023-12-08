using OfficeOpenXml;

namespace TaskList
{
    public static class ExcelOperation
    {
        private static readonly string _dataFile = Directory.GetCurrentDirectory() + "\\Data.xlsx";
        private static readonly string _nameSheet = "Список задач";
        public static List<Task> LoadDataXLSX()
        {
            List<Task> listTask = new();

            ExcelPackage book = new(_dataFile);
            ExcelWorksheet workSheet = book.Workbook.Worksheets[_nameSheet];

            return listTask;

        }
    }
}

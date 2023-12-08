using OfficeOpenXml;

namespace TaskList
{
    public static class ExcelOperation
    {
        private static readonly string _dataFile = Directory.GetCurrentDirectory() + "\\Data.xlsx";
        private static readonly string _nameSheet = "Список задач";
        public static List<Tasks> LoadDataXLSX()    // Загрузка файла
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            List<Tasks> listTask = new();

            ExcelPackage book = new(_dataFile);
            ExcelWorksheet workSheet = book.Workbook.Worksheets[_nameSheet];

            for (int i = 2; i <= workSheet.Dimension.End.Row; i++)
            {
                string name = workSheet.Cells[i, 1].Value.ToString()!;
                DateTime date = (DateTime)workSheet.Cells[i, 3].Value;
                Priority priority = (Priority)workSheet.Cells[i, 4].Value;
                Tasks temp = new(name, date, priority);
                listTask.Add(temp);
            }
            return listTask;
        }
        public static void CheckFileXLSX()  // Проверка на существование файла
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            if (!File.Exists(_dataFile))
            {
                ExcelPackage book = new(_dataFile);
                ExcelWorksheet workSheet = book.Workbook.Worksheets.Add(_nameSheet);
                workSheet.Cells[1, 1].Value = "Название";
                workSheet.Cells[1, 2].Value = "Статус";
                workSheet.Cells[1, 3].Value = "Время";
                workSheet.Cells[1, 4].Value = "Приоритет";
                book.Save();
            }
            
        }
        public static void SaveXLSX(List<Tasks> listTask)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage book = new(_dataFile);
            ExcelWorksheet workSheet = book.Workbook.Worksheets[_nameSheet];

            workSheet.Cells["A2:E1000"].Clear();

            for (int i = 0, row = 2; i < listTask.Count; i++, row++)
            {
                workSheet.Cells[row, 1].Value = listTask[i].Name;
                workSheet.Cells[row, 2].Value = listTask[i].StatusTask;
                workSheet.Cells[row, 3].Value = listTask[i].Date;
                workSheet.Cells[row, 4].Value = listTask[i].PriorityTask;
            }

            book.Save();
        }
    }
}

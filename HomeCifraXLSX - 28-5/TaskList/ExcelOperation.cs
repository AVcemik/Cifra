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
            if (workSheet == null)
            {
                workSheet = book.Workbook.Worksheets.Add(_nameSheet);
                book.Save();
            }
            else
            {
                for (int i = 1; i <= workSheet.Dimension.End.Row; i++)
                {
                    string name = workSheet.Cells[i, 1].Value.ToString()!;
                    DateTime date = DateTime.Parse(workSheet.Cells[i, 3].Text);
                    Priority priority = (Priority)int.Parse(workSheet.Cells[i, 4].Text);
                    Tasks temp = new(name, date, priority);
                    listTask.Add(temp);
                }
            }
            
            
            return listTask;
        }
        public static void SaveXLSX(List<Tasks> listTask)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage book = new(_dataFile);
            ExcelWorksheet workSheet = book.Workbook.Worksheets[_nameSheet];
            workSheet.Cells[$"A1:E{workSheet.Dimension.End.Row}"].Clear();
            for (int i = 0, row = 1; i < listTask.Count; i++, row++)
            {
                workSheet.Cells[row, 1].Value = listTask[i].Name;
                workSheet.Cells[row, 2].Value = (int)listTask[i].StatusTask;
                workSheet.Cells[row, 3].Value = listTask[i].Date;
                workSheet.Cells[row, 4].Value = (int)listTask[i].PriorityTask;
            }
            workSheet.Cells[$"C1:C{workSheet.Dimension.End.Row}"].Style.Numberformat.Format = "yyyy.mm.dd";
            book.Save();
        }
    }
}

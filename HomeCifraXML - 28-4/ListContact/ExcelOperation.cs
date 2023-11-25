using OfficeOpenXml;

namespace ListContact
{
    public static class ExcelOperation
    {
        private static readonly string _listName = "Контакты";

        public static void CheckFile()
        {
            ExcelPackage contactBook = new(Other.GetFilePath());
            ExcelWorksheet contactSheet = contactBook.Workbook.Worksheets.FirstOrDefault(x => x.Name == _listName);
            if (contactSheet == null)
            {
                contactSheet = contactBook.Workbook.Worksheets.Add(_listName);
                contactSheet.Cells[1, 1].Value = "Имя";
                contactSheet.Cells[2, 1].Value = "Номер телефона";
                contactSheet.Cells[3, 1].Value = "Эелектронный адрес";
                contactSheet.Cells[4, 1].Value = "Адрес";
            }
        }
    }
}

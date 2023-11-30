using OfficeOpenXml;

namespace ListContact
{
    public static class ExcelOperation
    {
        private static readonly string _listName = "Контакты";
        private static ExcelPackage contactBook = new(Other.GetFilePath());
        private static ExcelWorksheet contactSheet;

        public static void CheckFile()
        {
            
            for (int i = 0; i < contactBook.Workbook.Worksheets.Count; i++)
            {
                if (contactBook.Workbook.Worksheets[i].ToString() == _listName)
                {
                    contactSheet = contactBook.Workbook.Worksheets[i];
                    CheckColumnName();
                    break;
                }
                else if (i == contactBook.Workbook.Worksheets.Count)
                {
                    contactSheet = contactBook.Workbook.Worksheets.Add(_listName);
                    contactSheet.Cells[1, 1].Value = "Имя";
                    contactSheet.Cells[1, 2].Value = "Номер телефона";
                    contactSheet.Cells[1, 3].Value = "Электронный адрес";
                    contactSheet.Cells[1, 4].Value = "Адрес";
                    SaveFile();
                }
            }
            SetupStyleExcel();
            SaveFile();
        }
        public static void SaveFile()
        {
            contactBook.Save();
        }
        private static void SetupStyleExcel()
        {
            contactSheet.Column(1).Width = 30;
            contactSheet.Column(2).Width = 30;
            contactSheet.Column(3).Width = 30;
            contactSheet.Column(4).Width = 100;
        }
        private static void CheckColumnName()
        {
            if (contactSheet.Cells[1, 1].Value != "Имя")
                contactSheet.Cells[1, 1].Value = "Имя";

            if (contactSheet.Cells[1, 1].Value != "Номер телефона")
                contactSheet.Cells[1, 2].Value = "Номер телефона";

            if (contactSheet.Cells[1, 1].Value != "Электронный адрес")
                contactSheet.Cells[1, 3].Value = "Электронный адрес";

            if (contactSheet.Cells[1, 1].Value != "Адрес")
                contactSheet.Cells[1, 4].Value = "Адрес";
            SaveFile();

        }
    }
}

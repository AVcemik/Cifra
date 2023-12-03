using Microsoft.VisualBasic.ApplicationServices;
using OfficeOpenXml;

namespace ListContact
{
    public static class ExcelOperation
    {
        private static readonly string _listName = "Контакты";                  // Название листа
        private static ExcelPackage contactBook = new(Other.GetFilePath());     // Экземпляр книги
        private static ExcelWorksheet contactSheet = CheckFile();               // Экземпляр листа

        public static List<Contact> LoadDataList()  // Считывание данных из книги
        {
            List<Contact> list = new();
            for (int i = 0, row = 2; row <= contactSheet.Dimension.End.Row; i++, row++)
            {
                string name = contactSheet.Cells[row, 1].Value.ToString()!;
                string phone = contactSheet.Cells[row, 2].Value.ToString()!;
                string email = contactSheet.Cells[row, 3].Value.ToString()!;
                string adress = contactSheet.Cells[row, 4].Value.ToString()!;
                list.Add(new Contact(name, phone, email, adress));
            }
            return list;
        }
        public static ExcelWorksheet CheckFile()    // Проверка книги на целостность
        {
            ExcelWorksheet tempSheet;
            for (int i = 0; i < contactBook.Workbook.Worksheets.Count; i++)
            {
                if (contactBook.Workbook.Worksheets[i].ToString() == _listName)
                {
                    tempSheet = contactBook.Workbook.Worksheets[i];
                    if (tempSheet.Cells[1, 1].Value.ToString() != "Имя")
                        tempSheet.Cells[1, 1].Value = "Имя";

                    if (tempSheet.Cells[1, 2].Value.ToString() != "Номер телефона")
                        tempSheet.Cells[1, 2].Value = "Номер телефона";

                    if (tempSheet.Cells[1, 3].Value.ToString() != "Электронный адрес")
                        tempSheet.Cells[1, 3].Value = "Электронный адрес";

                    if (tempSheet.Cells[1, 4].Value.ToString() != "Адрес")
                        tempSheet.Cells[1, 4].Value = "Адрес";
                    return tempSheet;
                }
                else if (i == contactBook.Workbook.Worksheets.Count)
                {
                    
                }
            }
            tempSheet = contactBook.Workbook.Worksheets.Add(_listName);
            tempSheet.Cells[1, 1].Value = "Имя";
            tempSheet.Cells[1, 2].Value = "Номер телефона";
            tempSheet.Cells[1, 3].Value = "Электронный адрес";
            tempSheet.Cells[1, 4].Value = "Адрес";
            return tempSheet;
        }
        public static void SaveFile(List<Contact> listContact)  // Сохранение книги
        {
            int row = 2;
            contactSheet.Cells["A2:D1000"].Clear();
            foreach (var item in listContact)
            {
                contactSheet.Cells[row, 1].Value = item.Name;
                contactSheet.Cells[row, 2].Value = item.Phone;
                contactSheet.Cells[row, 3].Value = item.Email;
                contactSheet.Cells[row, 4].Value = item.Address;
                row++;
            }
            contactBook.Save();
            Other.DisplayNotificationMessage("Файл успешно сохранен.");
        }
        public static void SetupStyleExcel()    // Настройка стилей
        {
            contactSheet.Column(1).Width = 30;
            contactSheet.Column(2).Width = 30;
            contactSheet.Column(3).Width = 30;
            contactSheet.Column(4).Width = 100;
        }
        public static void CreateFile() // Создание файла
        {
            contactSheet = contactBook.Workbook.Worksheets.Add(_listName);
            contactSheet.Cells[1, 1].Value = "Имя";
            contactSheet.Cells[1, 2].Value = "Номер телефона";
            contactSheet.Cells[1, 3].Value = "Электронный адрес";
            contactSheet.Cells[1, 4].Value = "Адрес";
        }
    }
}

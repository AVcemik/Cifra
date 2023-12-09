using OfficeOpenXml;

namespace EditXLSX
{
    public static class XLSXOperation
    {
        public static string[,] LoadDataXLSX(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage book = new(path);
            
            ExcelWorksheet sheet = book.Workbook.Worksheets[0];
            if (sheet == null)
            {
                MessageBox.Show("Файл Excel поврежден", "Уведомдение");
            }
            else
            {
                for (int row = 1, i = 0; row <= sheet.Dimension.Rows; row++, i++)
                {
                    for (int column = 1, j = 0; column <= sheet.Dimension.Columns; column++, j++)
                    {
                        if (sheet.Cells[row, column].Text == "")
                            sheet.Cells[row, column].Clear();
                    }
                }
                string[,] dataXLSX = new string[sheet.Dimension.Rows,sheet.Dimension.Columns];
                for (int row = 1, i = 0; row <= sheet.Dimension.Rows; row++, i++)
                {
                    for (int column = 1, j = 0 ; column <= sheet.Dimension.Columns; column++, j++)
                    {
                        dataXLSX[i,j] = sheet.Cells[row, column].Text;
                    }
                }
                return dataXLSX;
            }
            return new string[0,0]; 
        }
        public static void SaveDataXLSX(string path, string[,] dataXLSX)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            ExcelPackage book = new(path);

            ExcelWorksheet sheet = book.Workbook.Worksheets["Лист 1"];
            if (sheet == null)
                sheet = book.Workbook.Worksheets.Add("Лист 1");

            for (int i = 0, row = 1; i < dataXLSX.GetLength(0); i++, row++)
            {
                for (int j = 0, column = 1; j < dataXLSX.GetLength(1); j++, column++)
                {
                    sheet.Cells[row, column].Value = dataXLSX[i,j];
                }
            }

            book.Save();
            MessageBox.Show("Файл сохранен", "Уведомление");
        }
    }
}

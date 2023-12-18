using Word = Microsoft.Office.Interop.Word;

namespace WordTable
{
    internal class Program
    {
        private static string _filePath = Directory.GetCurrentDirectory() + "\\Table.docx";
        static void Main(string[] args)
        {
            Random random = new();

            if (File.Exists(_filePath))
                File.Delete(_filePath);

            Word.Application wordApp = new();
            Word.Document doc = wordApp.Documents.Add();
            Word.Range range = doc.Content;

            try
            {
                Word.Table table = doc.Tables.Add(range, NumRows: 10, NumColumns: 10);

                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.OutsideColor = Word.WdColor.wdColorBlack;
                table.Borders.InsideColor = Word.WdColor.wdColorBlack;

                foreach (Word.Row row in table.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        cell.Range.Text = random.Next(100).ToString();
                    }
                }

                int result = 0;

                foreach (Word.Row row in table.Rows)
                {
                    foreach (Word.Cell cell in row.Cells)
                    {
                        result += int.Parse(cell.Range.Text.Trim('\\', '\r', '\a') ?? "0");
                    }
                }

                result /= 100;

                Word.Paragraph paragraph = doc.Paragraphs.Add();
                paragraph.Range.Text = $"\nСреднее арефмитическое значение в таблице: {result}\n";

                doc.SaveAs(_filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                doc.Close();
                wordApp.Quit();
            }
        }
    }
}

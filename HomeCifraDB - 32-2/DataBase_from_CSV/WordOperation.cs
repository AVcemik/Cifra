using Word = Microsoft.Office.Interop.Word;

namespace DataBase_from_CSV
{
    public static class WordOperation
    {
        public static void CreateTableWordBd(List<Iris> list)
        {
            Word.Application wordApp = new();
            Word.Document doc = wordApp.Documents.Add();

            try
            {
                Word.Range range = doc.Content;
                Word.Table table = doc.Tables.Add(range, list.Count + 1, Iris.GetCountPropherties());

                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.OutsideColor = Word.WdColor.wdColorBlack;
                table.Borders.InsideColor = Word.WdColor.wdColorBlack;

                for (int i = 0, row = 1; i < list.Count; i++, row++)
                {
                    table.Cell(row, 1).Range.Text = list[i].SepalLength.ToString();
                    table.Cell(row, 2).Range.Text = list[i].SepalWidth.ToString();
                    table.Cell(row, 3).Range.Text = list[i].PetalLength.ToString();
                    table.Cell(row, 4).Range.Text = list[i].PetalWidth.ToString();
                    table.Cell(row, 5).Range.Text = list[i].Variety.ToString();
                }

                doc.SaveAs(Directory.GetCurrentDirectory() + "\\iris.docx");
                Console.WriteLine("Word сохранен");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка обработки записи Word");
                Console.WriteLine();
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

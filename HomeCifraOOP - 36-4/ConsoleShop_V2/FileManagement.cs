namespace ConsoleShop_V2
{
    
    public class FileManagement
    {
        private static readonly string _pathLogTransaction = Directory.GetCurrentDirectory() + "\\LogTransaction.txt";
        
        public static void FileSave(string word)    // Добавление информации о транзакции
        {
            using (StreamWriter writerLogTransaction = new(_pathLogTransaction, true))
            {
                writerLogTransaction.WriteLine(word);
            }
        }
    }
}

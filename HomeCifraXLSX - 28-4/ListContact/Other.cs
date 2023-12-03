namespace ListContact
{
    internal static class Other
    {
        private static readonly string _filePath = Directory.GetCurrentDirectory() + "\\Адресная кнгига.xlsx"; // Полный путь до книги
        public static string GetFilePath()  // Получение полного пути к файлу
        {
            return _filePath;
        }
        public static void DisplayNotificationMessage(string word) // Вывод уведомления
        {
            MessageBox.Show(word, "Уведомление");
        }
        public static void DisplayErrorMessage(string word) // Вывод ошибки
        {
            MessageBox.Show(word, "Ошибка");
        }
    }
}

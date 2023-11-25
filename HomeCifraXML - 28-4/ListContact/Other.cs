namespace ListContact
{
    internal static class Other
    {
        private static readonly string _filePath = Directory.GetCurrentDirectory() + "Адресная кнгига.xlsx";

        public static string GetFilePath()  // Получение полного пути к файлу
        {
            return _filePath;
        }
    }
}

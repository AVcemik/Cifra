namespace ListContact
{
    internal static class Other
    {
        private static readonly string _filePath = Directory.GetCurrentDirectory() + "\\Адресная кнгига.xlsx";
        public static bool EditNoSaveData { get; set; } = false;

        public static string GetFilePath()  // Получение полного пути к файлу
        {
            return _filePath;
        }
        public static void ExitApp()
        {

                var result = MessageBox.Show("Изменения не сохранены", "Сохранить изменения?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // РЕализовать сохранение изменений
                }
                Application.Exit();

        }
    }
}

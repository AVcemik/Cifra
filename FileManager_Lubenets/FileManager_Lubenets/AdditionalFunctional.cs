namespace FileManager_Lubenets
{
    /// <summary>
    /// Дополнительный функционал...
    /// </summary>
    internal class AdditionalFunctional
    {
        private static string _defaultDirectory = @"C:\Users\cemik\Desktop";
        private static string _currentDirectory = _defaultDirectory;
        private static int _windowWidth = 120;
        private static int _windowHeight = 40;

        public static int WindowWidth
        {
            get => _windowWidth;
        }
        public static int WindowHeight
        {
            get => _windowHeight;
        }
        public static string DefaultPath
        {
            get => _defaultDirectory; 
        }
        public static string CurrentDirectory
        {
            get
            { 
                return _currentDirectory; 
            }
            set
            {
                _currentDirectory = value;
            }
        }

        /// <summary>
        /// Устанавливаем размер консоли
        /// </summary>
        /// <param name="width">Длина</param>
        /// <param name="height">Высота</param>
        public static void SetSizeConsole()
        {
            Console.SetWindowSize(WindowWidth, WindowHeight);
            Console.SetBufferSize(WindowWidth, WindowHeight);

        }

        public static void SetCursorPosition(int positionX, int poitionY)
        {
            Console.SetCursorPosition(positionX, poitionY);
        }
    }
}

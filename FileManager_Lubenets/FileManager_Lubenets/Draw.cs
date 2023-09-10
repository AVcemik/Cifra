namespace FileManager_Lubenets
{
    internal class Draw
    {

        public static void DrawWindow(int startPosition, int height)
        {
            Console.SetCursorPosition(0, startPosition);

            Console.Write("┌");
            for (int i = 0; i < AdditionalFunctional.WindowWidth - 2; i++)
            {
                Console.Write("─");
            }
            Console.Write("┐");

            for (int i = 0; i < height; i++)
            {
                Console.Write("│");
                for (int j = 0; j < AdditionalFunctional.WindowWidth - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("│");
            }

            Console.Write("└");
            for (int i = 0; i < AdditionalFunctional.WindowWidth - 2; i++)
            {
                Console.Write("─");
            }
            Console.Write("┘");
        }

        public static void DrawInputCommandField(string directory)
        {
            Console.SetCursorPosition(1, 31);
            if (Directory.Exists(directory))
            {
                Console.Write($"{directory}>");
            }
            else
            {
                throw new Exception("Такого пути не существует!");
            }
            
        }
    }
}

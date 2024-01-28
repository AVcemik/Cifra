using ConsoleShop.Category;

namespace ConsoleShop
{
    public static class Extention
    {
        public static User EnterUserAndMoney()
        {
            Console.Clear();
            Console.Write("Введите ваше Имя: ");
            string? name = Console.ReadLine();
            Console.Write("Введите кол-во ваших денег: ");
            decimal money = decimal.Parse(Console.ReadLine()!);

            return new User(name, money);
        }
        public static void DisplayListProduct(List<IProduct> products)
        {
            for (int i = 0, numberItem = 1; i < products.Count; i++, numberItem++)
            {
                Console.WriteLine($"[{numberItem}] - {products[i].Name} - {products[i].Price} - {products[i].Description} - {products[i].Manufacture}");
            }
        }

        public static List<Motherbord> ListMotherBord()
        {
            return new List<Motherbord>()
            {
                new Motherbord("Biostar A68MHE", 2699M, "Материнская плата Biostar A68MHE", "Китай", Socket.AM5),
                new Motherbord("GIGABYTE H410M H V2", 5999M, "Материнская плата GIGABYTE H410M H V2", "Китай", Socket.AM4),
                new Motherbord("ASRock H370M-HDV", 5599M, "Материнская плата ASRock H370M-HDV", "Вьетнам", Socket.LGA1700),
            };
        }
        public static List<Processor> ListProcessor()
        {
            return new List<Processor>()
            {
                new Processor("AMD PRO A6-8570 OEM", 1999M, "Процессор AMD PRO A6-8570 OEM", "Китай", 3.5, 2,Socket.AM4),
                new Processor("Intel Pentium G4400 OEM", 2850M, "Процессор Intel Pentium G4400 OEM", "Вьетнам", 3.3, 2,Socket.LGA1151),
                new Processor("Intel Celeron G5905 BOX", 4390M, "Процессор Intel Celeron G5905 BOX", "Китай", 3.5, 2,Socket.LGA1200),
            };
        }
        public static List<Videocard> ListVideocard()
        {
            return new List<Videocard>()
            {
                new Videocard("PowerColor AMD Radeon R7 240", 4999M, "Видеокарта PowerColor AMD Radeon R7 240", "Китай", 730, 2),
                new Videocard("MSI GeForce GT 730", 5599M, "Видеокарта MSI GeForce GT 730", "Китай", 700, 2),
                new Videocard("GIGABYTE GeForce GT 710 Silent LP", 6499M, "Видеокарта GIGABYTE GeForce GT 710 Silent LP", "Вьетнам", 954, 2),
            };
        }
        public static List<IProduct> ListProduct()
        {
            return new List<IProduct>()
            {
                new Motherbord("Biostar A68MHE", 2699M, "Материнская плата Biostar A68MHE", "Китай", Socket.AM5),
                new Motherbord("GIGABYTE H410M H V2", 5999M, "Материнская плата GIGABYTE H410M H V2", "Китай", Socket.AM4),
                new Motherbord("ASRock H370M-HDV", 5599M, "Материнская плата ASRock H370M-HDV", "Вьетнам", Socket.LGA1700),

                new Processor("AMD PRO A6-8570 OEM", 1999M, "Процессор AMD PRO A6-8570 OEM", "Китай", 3.5, 2,Socket.AM4),
                new Processor("Intel Pentium G4400 OEM", 2850M, "Процессор Intel Pentium G4400 OEM", "Вьетнам", 3.3, 2,Socket.LGA1151),
                new Processor("Intel Celeron G5905 BOX", 4390M, "Процессор Intel Celeron G5905 BOX", "Китай", 3.5, 2,Socket.LGA1200),

                new Videocard("PowerColor AMD Radeon R7 240", 4999M, "Видеокарта PowerColor AMD Radeon R7 240", "Китай", 730, 2),
                new Videocard("MSI GeForce GT 730", 5599M, "Видеокарта MSI GeForce GT 730", "Китай", 700, 2),
                new Videocard("GIGABYTE GeForce GT 710 Silent LP", 6499M, "Видеокарта GIGABYTE GeForce GT 710 Silent LP", "Вьетнам", 954, 2),
            };
        }
    }
}

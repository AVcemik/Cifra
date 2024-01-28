namespace ConsoleShop_V2
{
    public enum ColorWord
    {
        Green,
        Red
    }
    public static class Extension
    { 
        public static List<Product> ListProduct()   // Наполнение данными продуктов
        {
            return new List<Product>()
            {
                new Motherbord("Biostar A68MHE", 2699, "Материнская плата Biostar A68MHE", "Китай", Socket.AM5),
                new Motherbord("GIGABYTE H410M H V2", 5999, "Материнская плата GIGABYTE H410M H V2", "Китай", Socket.AM4),
                new Motherbord("ASRock H370M HDV", 5599, "Материнская плата ASRock H370M HDV", "Вьетнам", Socket.LGA1700),

                new Processor("AMD PRO A6 8570 OEM", 1999, "Процессор AMD PRO A6 8570 OEM", "Китай", 3.5, 2,Socket.AM4),
                new Processor("Intel Pentium G4400 OEM", 2850, "Процессор Intel Pentium G4400 OEM", "Вьетнам", 3.3, 2,Socket.LGA1151),
                new Processor("Intel Celeron G5905 BOX", 4390, "Процессор Intel Celeron G5905 BOX", "Китай", 3.5, 2,Socket.LGA1200),

                new Videocard("PowerColor AMD Radeon R7 240", 4999, "Видеокарта PowerColor AMD Radeon R7 240", "Китай", 730, 2),
                new Videocard("MSI GeForce GT 730", 5599, "Видеокарта MSI GeForce GT 730", "Китай", 700, 2),
                new Videocard("GIGABYTE GeForce GT 710 Silent LP", 6499, "Видеокарта GIGABYTE GeForce GT 710 Silent LP", "Вьетнам", 954, 2),

                new PowerSupply("AeroCool VX PLUS", 4199, "Блок питания AeroCool VX PLUS", "Китай", 750),
                new PowerSupply("Xilence Gaming series XN240", 7799, "Блок питания Xilence Gaming series XN240", "Китай", 850),
                new PowerSupply("Cougar BXM 1000", 10599, "Блок питания Cougar BXM 1000", "Китай", 1000),

                new Housing("DEXP DC 302G серый", 1650, "Корпус DEXP DC 302G серый", "Китай", 355, 175, 405),
                new Housing("AeroCool CS 103 [CS 103 S BK v1] черный", 3199, "Корпус AeroCool CS 103 [CS 103 S BK v1] черный", "Китай", 371, 199, 357),
                new Housing("AeroCool Cs 102 черный", 2850, "Корпус AeroCool Cs 102 черный", "Китай", 345, 190, 372),

                new CoolingSystem("DarkFlash AURA DA360", 4499, "Система охлаждения DarkFlash AURA DA360", "Китай", 76.8),
                new CoolingSystem("DEXP DX60NFDB", 150, "Вентилятор DEXP DX60NFDB", "Китай", 15.7),
                new CoolingSystem("AeroCool Verkho A-3P", 699, "Кулер для процессора AeroCool Verkho A-3P", "Китай", 61.32),
            };
        }
    }
}

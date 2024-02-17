using HomeCifraWPF___96.Models;
using System.Collections.ObjectModel;
namespace HomeCifraWPF___96.Services
{
    public class ProductListCreator
    {
        public static ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
            {
                new (1, "Телефон", "Мощный телефон для игр", 5000M, 2),
                new (2, "Планшет", "Выбор дизайнеров", 15000M, 1),
                new (3, "Ноутбук", "Ноутбук для работы", 30000M, 3),
                new (4, "Монитор", "Разрешение 4К", 12000M, 4),
                new (5, "Клавиатура", "Механическая белая", 2500M, 5),
                new (6, "Мышь", "С подсветкой", 1800M, 6),
                new (7, "Принтер", "Цветной лазерный", 8000M, 7),
                new (8, "Колонки", "Чистый хороший звук", 4000M, 8),
                new (9, "Флешка", "Объем 10 ПтБ", 2000M, 9)
            };
        }
    }
}

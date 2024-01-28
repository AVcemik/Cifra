using ConsoleShop;
using ConsoleShop.Category;

User user = Extention.EnterUserAndMoney();
List<IProduct> listProduct = Extention.ListProduct();


while (true)
{
    Console.Clear();
    Extention.DisplayListProduct(listProduct);

    Console.ReadKey();
}

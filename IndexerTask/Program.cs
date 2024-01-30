using IndexerTask;
using Task0130;

ProductList productList = new ProductList(3);

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter Product {i + 1} Number: ");
    int productNumber = int.Parse(Console.ReadLine());

    Console.Write($"Enter Product {i + 1} Name: ");
    string productName = Console.ReadLine();

    productList[i] = new Product(productNumber, productName);
}

Console.WriteLine("\nProducts Entered:");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Product {productList[i].ProductNumber}: {productList[i].ProductName}");
}

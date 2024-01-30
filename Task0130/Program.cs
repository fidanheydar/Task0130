using Task0130;

int productCount;
do
{
    Console.Write("Enter the number of products: ");
    string countInput = Console.ReadLine();

    if (int.TryParse(countInput, out productCount) && productCount >= 0) break; 
    else
        Console.WriteLine("Invalid input. Please enter a non-negative integer for the product count.");
} while (true);

Product[] products = new Product[productCount];

for (int i = 0; i < productCount; i++)
{
    Product product = new Product();
    do
    {
        Console.Write($"Enter the name for Product {product.No}: ");
        product.Name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(product.Name))
            Console.WriteLine("Please enter a valid product name.");
        
        else
            break; 
        
    } while (true);

    do
    {
        Console.Write("Enter the price: ");
        string priceInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(priceInput))
        {
            Console.WriteLine("Please enter a valid price.");
            continue;
        }

        if (double.TryParse(priceInput, out double price))
        {
            product.Price = price;
            break;
        }
        else
            Console.WriteLine("Invalid input. Please enter a valid numeric value for the price.");
        
    } while (true);

   
    do
    {
        Console.Write("Enter the type (Baker, Drink, Meat, Diary): ");
        string typeInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(typeInput))
        {
            Console.WriteLine("Please enter a valid product type.");
            continue;
        }

        if (Enum.TryParse(typeInput, out ProductType productType) && Enum.IsDefined(typeof(ProductType), productType))
        {
            product.Type = productType;
            break;
        }
        else
            Console.WriteLine("Invalid product type. Please enter a valid product type.");
        
    } while (true);

    products[i] = product;
}
Console.WriteLine("\nProduct Details:\n");
foreach (var product in products)
{
    Console.WriteLine($"No: {product.No}, Name: {product.Name}, Price: {product.Price}, Type: {product.Type}");
}

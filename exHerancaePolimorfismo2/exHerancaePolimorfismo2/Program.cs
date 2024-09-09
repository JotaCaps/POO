// See https://aka.ms/new-console-template for more information
using exHerancaePolimorfismo2.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for (int i = 0; i < n; i++)
{
    Console.Write("Common, use or imported (c/u/i)? ");
    char r = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (r == 'u')
    {
        Console.WriteLine("Manufacture Day: ");
        DateTime manuDate = DateTime.Parse(Console.ReadLine());

        products.Add(new UsedProduct(name, price, manuDate));
    }
    else if (r == 'i')
    {
        Console.WriteLine("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else 
    {
        products.Add(new Product(name, price));
    }   
}

Console.WriteLine();
Console.WriteLine("PRICETAGS: ");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}

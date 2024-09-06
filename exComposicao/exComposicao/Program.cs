using exComposicao.Entities;
using exComposicao.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date: ");
DateTime birth = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birth);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many itens to this order? ");
int c = int.Parse(Console.ReadLine());

Order order1 = new Order(DateTime.Now, status, client);

for (int i = 1; i <= c; i++)
{
    Console.WriteLine($"Enter {i} item data: ");
    Console.Write("Product name: ");
    string itemName = Console.ReadLine();
    Console.Write("Product price: ");
    double itemPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Quantity: ");
    int qtd = int.Parse(Console.ReadLine());

    Product item = new Product(itemName, itemPrice);
    OrderItem orderItem = new OrderItem(qtd, itemPrice, item);
    order1.AddItem(orderItem);
}

Console.WriteLine("ORDER SUMMARY");
Console.WriteLine("Order Moment: " + order1.Moment);
Console.WriteLine("Order Status: " + order1.Status);
Console.WriteLine("Client: " + order1.client.Name + " " + order1.client.BirthDate.ToString("(dd/MM/yyyy)") + " - " + order1.client.Email);
Console.WriteLine("Order Items: ");
foreach(OrderItem item in order1.Items)
    Console.WriteLine(item);
Console.WriteLine("Total Price: $" + order1.Total().ToString("F2"), CultureInfo.InvariantCulture);



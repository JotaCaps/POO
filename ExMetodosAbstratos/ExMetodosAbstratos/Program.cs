using ExMetodosAbstratos.Entities;
using ExMetodosAbstratos.Entities.Enums;
using System.Globalization;


Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

List<Shape> shapes = new List<Shape>();

for (int i = 0; i < n; i++)
{
    Console.Write("Rectangle or Cicle (r/c)? ");
    char r = char.Parse(Console.ReadLine());
    if (r == 'r')
    {
        Console.WriteLine("Color: ");
        Color color = Enum.Parse<Color>(Console.ReadLine());
        Console.WriteLine("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Rectangle(color, width, height));
    }
    else
    {
        Console.WriteLine("Color: ");
        Color color = Enum.Parse<Color>(Console.ReadLine());
        Console.WriteLine("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        shapes.Add(new Circle(color, radius));
    }
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS: ");
foreach(Shape shape in shapes)
    Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));

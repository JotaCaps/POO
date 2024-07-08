// See https://aka.ms/new-console-template for more information
using System.Globalization;

using ex001ClassesAtributosMetodos;

Console.WriteLine("Entre com a largura e altura do retângulo: ");

Retangulo r = new Retangulo();

r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA: "+ r.Area().ToString("F2"), CultureInfo.InvariantCulture);
Console.WriteLine($"PERÍMETRO: " + r.Perimetro().ToString("F2"), CultureInfo.InvariantCulture);
Console.WriteLine($"DIAGONAL: " + r.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);


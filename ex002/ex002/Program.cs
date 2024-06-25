// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Digite um número: ");
double n = double.Parse(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("NEGATIVO");
}
else
{
    Console.WriteLine("NÃO NEGATIVO");
}

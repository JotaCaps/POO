// See https://aka.ms/new-console-template for more information
using System.Globalization;

string[] valores = Console.ReadLine().Split(' ');
int codigo = int.Parse(valores[0]);
int qtd = int.Parse(valores[1]);

double resultado;

if (codigo == 1)
{
    resultado = 4.00 * qtd;
}
else if (codigo == 2)
{
    resultado = 4.50 * qtd;
}
else if (codigo == 3)
{
    resultado = 5.00 * qtd;
}
else if (codigo == 4)
{
    resultado = 2.00 * qtd;
}
else
{
    resultado = 1.50 * qtd;
}

Console.WriteLine($"Total: R$: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

// See https://aka.ms/new-console-template for more information
using Ex001MembrosEstaticos;
using System.Globalization;

Console.Write("Qual a cotação do Dólar? ");
double ValorDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantos doláres você vai comprar? :");
double reais = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Conversor(ValorDolar, reais).ToString("F2", CultureInfo.InvariantCulture));

// See https://aka.ms/new-console-template for more information
using ex001Classes;

Pessoa pessoa1, pessoa2;

Console.WriteLine("Primeira pessoa: ");

pessoa1 = new Pessoa();

pessoa1.Nome = Console.ReadLine();
pessoa1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Segunda pessoa: ");

pessoa2 = new Pessoa();

pessoa2.Nome = Console.ReadLine();
pessoa2.Idade = int.Parse(Console.ReadLine());

if (pessoa1.Idade > pessoa2.Idade)
{
    Console.WriteLine($"{pessoa1.Nome} é mais velho(a)!");
}
else 
{
    Console.WriteLine($"{pessoa2.Nome} é mais velho(a)!");
}





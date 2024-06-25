// See https://aka.ms/new-console-template for more information

string[] numeros = Console.ReadLine().Split(' ');

int a = int.Parse(numeros[0]);
int b = int.Parse(numeros[1]);

if (a % b == 0)
{
    Console.WriteLine("São Multiplos!");
}
else if (b % a == 0)
{
    Console.WriteLine("São Multiplos!");
}
else 
{
    Console.WriteLine("Não são Multiplos!");
}
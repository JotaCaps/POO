// See https://aka.ms/new-console-template for more information
using ExVetores;
using System.Globalization;
using System.Numerics;

Console.WriteLine("Quantos quartos serão alugados? ");
int n = int.Parse(Console.ReadLine());

Aluno[] vect = new Aluno[10];

vect[2] = new Aluno("Jon", "Hotmail");

for (int i = 0; i < n; i++)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());

    vect[quarto] = new Aluno(nome, email);   
}

for (int i = 0; i < 10; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine(i + ": " + vect[i]);
    }
}



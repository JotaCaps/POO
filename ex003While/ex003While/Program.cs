// See https://aka.ms/new-console-template for more information

int alcool = 0;
int gasolina = 0;
int diesel = 0;

int resposta = int.Parse(Console.ReadLine());

while (resposta != 4)
{
    if (resposta == 1)
    {
        alcool = alcool + 1;
    }
    else if (resposta == 2)
    {
        gasolina = gasolina + 1;
    }
    else if (resposta == 3)
    {
        diesel = diesel +1;
    }

    resposta = int.Parse(Console.ReadLine());

    Console.WriteLine("MUITO OBRIGADO!");
    Console.WriteLine($"Alcool: {alcool}");
    Console.WriteLine($"Gasolina: {gasolina}");
    Console.WriteLine($"Diesel: {diesel}");
}
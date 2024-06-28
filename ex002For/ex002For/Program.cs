// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite quantos valores você quer ler: ");
int N = int.Parse(Console.ReadLine());

int X = 0;
int dentro = 0;
int fora = 0;

for (int i = 1; i <= N; i++)
{
    X = int.Parse(Console.ReadLine());

    if (X < 10 || X > 20)
    {
        fora += 1;      
    }

    if (X >= 10 && X <= 20)
    {
        dentro += 1;  
    }
}

Console.WriteLine($"{dentro} in");
Console.WriteLine($"{fora} out");





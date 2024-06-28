// See https://aka.ms/new-console-template for more information

using System.Globalization;

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    int n1 = int.Parse(line[0]);
    int n2 = int.Parse(line[1]);

    if (n2 == 0)
    {
        Console.WriteLine("Divisão Impossível!");
    }
    else
    {
        double divisao = (double)n1 / n2; 
        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
    }
}

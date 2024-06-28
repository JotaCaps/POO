// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número: ");
int valor = int.Parse(Console.ReadLine());

for (int i = 1;  i <= valor; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
    
}

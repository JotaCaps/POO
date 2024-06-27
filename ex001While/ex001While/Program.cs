// See https://aka.ms/new-console-template for more information

Console.WriteLine("Senha: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Senha Inválida!");
    Console.WriteLine("Senha: ");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido!");

// See https://aka.ms/new-console-template for more information
using ex003ClassesMetodosAtributos;

using System.Globalization;

Aluno a = new Aluno();


Console.WriteLine("Nome do Aluno: ");
a.Nome = Console.ReadLine();

Console.WriteLine("Nota 1: ");
a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Nota 2: ");
a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Nota 3: ");
a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Nota Final: " + a.NotaFinal().ToString("F2"), CultureInfo.InvariantCulture);

if (a.Aprovado())
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
    Console.WriteLine("Faltaram: "
                        + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                        + " Pontos");


}


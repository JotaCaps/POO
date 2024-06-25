// See https://aka.ms/new-console-template for more information

string[] valores = Console.ReadLine().Split(' ');
int horaInicial = int.Parse(valores[0]);
int horaFinal = int.Parse(valores[1]);

int duracao;

if(horaInicial < horaFinal)
{
    duracao = horaFinal - horaInicial;
}
else
{
    duracao = 24 - horaInicial + horaFinal;
}

Console.WriteLine($"O jogo durou {duracao} horas!");
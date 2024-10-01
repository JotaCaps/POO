// See https://aka.ms/new-console-template for more information
using exPropostConjuntos.Entities;

HashSet<Student> set = new HashSet<Student>();

Console.Write("How many studens for course A? ");
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    int course = int.Parse(Console.ReadLine());
    set.Add(new Student(course));
}

Console.Write("How many studens for course B? ");
int b = int.Parse(Console.ReadLine());
for (int i = 0; i < b; i++)
{
    int course = int.Parse(Console.ReadLine());
    set.Add(new Student(course));
}

Console.Write("How many studens for course C? ");
int c = int.Parse(Console.ReadLine());
for (int i = 0; i < c; i++)
{
    int course = int.Parse(Console.ReadLine());
    set.Add(new Student(course));
}

Console.WriteLine("Total Students: " + set.Count);


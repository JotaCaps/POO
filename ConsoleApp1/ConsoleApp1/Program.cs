// See https://aka.ms/new-console-template for more information
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[m, n];

for (int i = 0; i < m; i++)
{
    string[] values = Console.ReadLine().Split(" ");

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]); 
    }
}

int x  = int.Parse(Console.ReadLine());
if (mat[m, n] == x)
{
    Console.WriteLine(mat.GetLength(0) + " " + mat.GetLength(1)); 
}
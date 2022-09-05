// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int n = 4;
int m = 3;
double[,] matrix = new double[m, n];
Random Random = new Random();
for (int i = 0; i < m; i++)
{
    Console.WriteLine("i = " + i); 
    for(int j = 0; j < n; j++)
    {
        Console.WriteLine("j = " + j); 
        matrix[i, j] = Random.NextDouble() * 10;
    }
}

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "  ");
    }
    Console.WriteLine();
}

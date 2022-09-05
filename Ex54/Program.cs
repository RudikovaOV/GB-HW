// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

Console.Clear();
int n = 4;
int m = 5;
int[,] matrix = new int[n, m];
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        matrix[i, j] = rnd.Next(10, 50);
    }
}
Console.WriteLine("Исходная матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m - 1; k++)
        {
            if (matrix[i, k] > matrix[i, k + 1])
            {
                int t = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = t;
            }
        }
    }
}
Console.WriteLine("Отсортированная по строкам матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


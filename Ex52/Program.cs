// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int n = 4;
int m = 3;
int[,] matrix = new int[m, n]; //m-строк, n - столбцов
double[] sums = new double[n];
Random Random = new Random();
for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = Random.Next(10, 100);
        sums[j] = sums[j] + matrix[i, j]; //i = 0, j = 0
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

Console.WriteLine("Среднее арифметическое столбцов:");
for (int i = 0; i < n; i++) {
        sums[i] = sums[i] / m;
        Console.Write(sums[i] + " ");
}

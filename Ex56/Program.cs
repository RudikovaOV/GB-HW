// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int n = 5;
int m = 10;
int[,] matrix = new int[m, n]; //m-строк, n - столбцов
int[] sums = new int[m];
Random Random = new Random();
for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = Random.Next(10, 100);
        sums[i] = sums[i] + matrix[i, j]; //i = 0, j = 0
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

Console.WriteLine("Суммы строк:");

for (int i = 0; i < m; i++) {
        Console.Write(sums[i] + " ");
}
    Console.WriteLine();
    Console.WriteLine();
int min_sum = sums[0];
int min_sum_index = 0;
for (int i = 1; i < m; i++)
{
    if (sums[i] < min_sum)
    {
            min_sum = sums[i];
            min_sum_index = i;
    }
        
}
Console.WriteLine("min_Sum = " + min_sum);
Console.WriteLine("Index = " + min_sum_index);
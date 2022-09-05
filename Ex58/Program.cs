// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();
int n1 = 3;
int m1 = 2;
int m2 = 5;
int[,] matrix_A = new int[m1, n1]; //m1-строк, n1 - столбцов
int[,] matrix_B = new int[n1, m2]; //n1-строк, m2 - столбцов
Random Random = new Random();
for (int i = 0; i < m1; i++)
{
    for(int j = 0; j < n1; j++)
    {
        matrix_A[i, j] = Random.Next(1, 10);
    }
}

for (int i = 0; i < n1; i++)
{
    for (int j = 0; j < m2; j++)
    {
           matrix_B[i, j] = Random.Next(1, 10);
    }
}
Console.WriteLine("Матрица А");
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            Console.Write(matrix_A[i, j] + "  ");
        }
        Console.WriteLine();
    }

Console.WriteLine("Матрица B");
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < m2; j++)
        {
            Console.Write(matrix_B[i, j] + "  ");
        }
        Console.WriteLine();
    }

int[,] matrix_C = new int[m1, m2];

for (int i = 0; i < m1; i++)
{
    for (int j = 0; j < m2; j++)
    {
        for (int k = 0; k < n1; k++)
            {
                matrix_C[i, j] = matrix_C[i, j] + (matrix_A[i, k] * matrix_B[k, j]);
            }
    }
}
    Console.WriteLine("Матрица C");
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < m2; j++)
        {
            Console.Write(matrix_C[i, j] + "  ");
        }
        Console.WriteLine();
    }


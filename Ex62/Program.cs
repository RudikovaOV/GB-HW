// Задача 62. Заполните спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
// 10 9 8 7

Console.Clear();
int n = 6;
int[,] matrix = new int[n, n];
int i = 0; //координата по строке
int j = 0; //координата по столбцу

for(int number = 1; number <= n*n; number++)
{
    matrix[i, j] = number;
    if((i + j < n - 1) && (i <= j + 1)){
        j = j + 1;
    }
    else if ((i + j >= n - 1) && (i < j))
    {
        i = i + 1;
    }
    else if ((i + j > n - 1) && (i >= j))
    {
        j = j - 1;
    }
    else
    {
        i = i - 1;
    }
}


for (int str = 0; str < n; str++)
{
    for (int col = 0; col < n; col++)
    {
        Console.Write(matrix[str, col] + " ");
    }
    Console.WriteLine();
}



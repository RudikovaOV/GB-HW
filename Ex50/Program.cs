// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int n = 4;
int m = 3;
int[,] matrix = new int[m, n];
Random Random = new Random();
for (int i = 0; i < m; i++)
{
  
    for(int j = 0; j < n; j++)
    {
        matrix[i, j] = Random.Next(10, 100);
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

Console.WriteLine("Введите желаемые координаты");
int N_user = Convert.ToInt32(Console.ReadLine());
int M_user = Convert.ToInt32(Console.ReadLine());

if ((N_user > n) || (M_user > m))
{
    Console.WriteLine("Такого элемента нет!");
}
else if ((N_user < 0) || (M_user < 0))
{
    Console.WriteLine("Неверный ввод!");
}
else
{
    Console.WriteLine(matrix[N_user, M_user]);
}

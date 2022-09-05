// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
int n = 4;
int m = 2;
int l = 2;
int[,,] array_3D = new int[n, m, l];
int number = 10;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < l; k++)
        {
            array_3D[i, j, k] = number;
            number = number + 3;
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < l; k++)
        {
            Console.WriteLine(array_3D[i, j, k] + "(" + i + "," + j + "," + k + ")");
        }
    }
}

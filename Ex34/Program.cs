// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Random rnd = new Random();
int[] arr = new int[10];
int k = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
    if (arr[i] % 2 == 0)
    {
        k = k + 1;
    }
}
//для вывода на экран
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Количество четных = " + k);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] arr = new double[5] {3, 7, 22, 2, 78};
double max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

double min = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
Console.WriteLine("max - min = " + (max - min));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Random rnd = new Random();
int[] arr = new int[10];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-1000, 1000);
    if (i % 2 != 0)
    {
        sum = sum + arr[i];
    }
}
//для вывода на экран
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Сумма на нечетных позициях = " + sum);

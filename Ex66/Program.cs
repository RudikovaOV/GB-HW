﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();
int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = N; i <= M; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);


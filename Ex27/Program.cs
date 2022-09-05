// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int data = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (data != 0)
{
  int zifra = data % 10;
  sum = sum + zifra;
  data = data / 10;
}
Console.WriteLine(sum);
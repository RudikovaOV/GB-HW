// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.WriteLine("Введите число");
string A_data = Console.ReadLine();
Console.WriteLine("Введите показатель степени");
string B_data = Console.ReadLine();
int A = Convert.ToInt32(A_data);
int B = Convert.ToInt32(B_data);

long stepen = 1;

for (int i = 0; i < B; i++)
{
    stepen = stepen * A;
}
Console.WriteLine("Степень = " + stepen);

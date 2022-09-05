// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int M = 5;
Console.WriteLine("Введите " + M + "чисел");
int k = 0;
for(int i = 0; i < M; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        k = k + 1;
    }
}
Console.WriteLine("Количество чисел >0 = " + k);





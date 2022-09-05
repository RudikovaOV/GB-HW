// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
int number_of_day = Convert.ToInt32(Console.ReadLine());
if ((number_of_day == 6) || (number_of_day == 7)){
    Console.WriteLine("Выходной!");
}
else
{
    Console.WriteLine("Рабочий день!");
}


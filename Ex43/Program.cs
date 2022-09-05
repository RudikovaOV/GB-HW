// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.Clear();
Console.WriteLine("Введите k1 и b1");
double k1 = Convert.ToInt32(Console.ReadLine());
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2 и b2");
double k2 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Они параллельны");
}
else
{
    double x_per = (b2 - b1) / (k1 - k2);
    double y_per = k1 * x_per + b1;
    Console.WriteLine("Точка = (" + x_per + "," + y_per + ")");
}
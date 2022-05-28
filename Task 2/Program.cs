/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double GetNumber()
{
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}
double GetX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double GetY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.WriteLine("Введите число k1: ");
double k1 = GetNumber();
Console.WriteLine("Введите число b1: ");
double b1 = GetNumber();
Console.WriteLine("Введите число k2: ");
double k2 = GetNumber();
Console.WriteLine("Введите число b2: ");
double b2 = GetNumber();

Console.WriteLine($"Прямые заданы уравнениями: y = {k1}x + {b1} и y = {k2}x + {b2}");

double x = GetX(k1, b1, k2, b2);
double y = GetY(k1, b1, x);

Console.WriteLine($"Координаты пересечения прямых: ({x}; {y})");

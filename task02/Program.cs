/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


int getNumberFromUser(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = getNumberFromUser("Введите значение b1: ");
double k1 = getNumberFromUser("Введите значение k1: ");
double b2 = getNumberFromUser("Введите значение b2: ");
double k2 = getNumberFromUser("Введите значение k2: ");
if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются");
    }
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения двух прямых ({x};{y})");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите значение b1 ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1 ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2 ");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2 ");
double num4 = Convert.ToDouble(Console.ReadLine());

double XPoint(double number1, double number2, double number3, double number4)
{
    double result = (num3 - num1) / (num2 - num4);
    return result;
}
double x = XPoint(num1, num2, num3, num4);

double YPoint(double n1, double n2, double n3, double n4)
{
    double result = n2 * ((n3 - n1) / (n2 - n4)) + n1;
    return result;
}
double y = YPoint(num1, num2, num3, num4);

if (num2 == num4)
    Console.WriteLine("Прямые параллельны ");
else 
    Console.WriteLine($"Точка x равна {x}, точка y равна {y} ");


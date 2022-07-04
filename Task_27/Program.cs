// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int SumDigit (int num1)
{
while (num >= 1)
{
    sum += num % 10;
    num = (num - num % 10) / 10;
}
return (sum);
}
int num1 = SumDigit(sum);
Console.WriteLine($"Сумма цифр числа равна {num1}");
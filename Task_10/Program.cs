// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
//  на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона от 100 до 999 => {rndNum}");
// int secDigit = rndNum % 100 / 10;
// Console.WriteLine($"Второе число {secDigit}");

int SecondDigit(int num)
{
int secDigit = (num % 100) / 10;
int result = secDigit;
return result;
}
int res = SecondDigit(rndNum);
Console.WriteLine($"Второе число {res}");

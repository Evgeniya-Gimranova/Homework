﻿// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int a;
Console.WriteLine("Введите трехзначное число ");
a = Convert.ToInt32(Console.ReadLine());
int b = a % 10;
Console.WriteLine($"Последняя цифра {b}");

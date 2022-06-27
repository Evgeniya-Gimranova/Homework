// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели ");
int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0 && num < 8)
// {
//     if (num == 1) Console.WriteLine("Нет");
//     else if (num == 2) Console.WriteLine("Нет");
//     else if (num == 3) Console.WriteLine("Нет");
//     else if (num == 4) Console.WriteLine("Нет");
//     else if (num == 5) Console.WriteLine("Нет");
//     else if (num == 6) Console.WriteLine("Да");
//     else if (num == 7) Console.WriteLine("Да");
//  }
//  else  Console.WriteLine("Такого дня недели не существует");

void DayNumber(int num)
{
    if ((num) == 6 || (num) == 7) Console.WriteLine("Выходной -> Да");
    else if ((num) > 0 && (num) < 6) Console.WriteLine("Не выходной -> Нет");
    else Console.WriteLine("Под таким номером дня недели не существует");
}
DayNumber(num);
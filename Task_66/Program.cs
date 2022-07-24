// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ");
int numN = Convert.ToInt32(Console.ReadLine());

int NaturalNumberSum(int m, int n)
{
    if (n > m)  return n + NaturalNumberSum(m, n - 1); 

    return m;
}
int naturalSum = NaturalNumberSum(numM, numN);

Console.WriteLine($"Сумма элементов от {numM} до {numN} = {naturalSum}");
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент ");
int maxElement = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ", ");
            else Console.Write(arr[i, j] + "]");
        }
        Console.WriteLine();
    }
}
int[,] matrix = CreateMatrixRndInt(num1, num2, minElement, maxElement);

int MinSumLine(int[,] arr2)
{
    int minsum = int.MaxValue;
    int indexRow = 0;

    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            sum = sum + arr2[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexRow++;
        }
    }
    return indexRow;

}
int minSumLine = MinSumLine(matrix);
Console.WriteLine($"{minSumLine} - строкa с наименьшей суммой элементов");


PrintMatrix(matrix);







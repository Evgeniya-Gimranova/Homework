// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double result = 0;
double AverageOfColumnElements(int[,] arr, int n, double sum)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];

        }
        sum = sum / n;
        Console.Write(sum + " ; ");
    }
    return sum;
}

int[,] matrix = CreateMatrixRndInt(num1, num2, minElement, maxElement);
PrintMatrix(matrix);
Console.WriteLine();
double average = AverageOfColumnElements(matrix, num1, result);

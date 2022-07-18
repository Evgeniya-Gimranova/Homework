// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void SortLineMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - j - 1; k++)
            {
                if (arr[i, k] > arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrixRndInt(num1, num2, minElement, maxElement);
Console.WriteLine ("Исходная матрица ");
PrintMatrix(matrix);
Console.WriteLine();
SortLineMatrix(matrix);
Console.WriteLine("Отсортированная матрица по убыванию ");
PrintMatrix(matrix);
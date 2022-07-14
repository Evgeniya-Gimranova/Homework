// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.WriteLine("Введите номер строки ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] array = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10,100);
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

void FindMatrixElement(int[,] arr, int a, int b)
{
    
            if (b > arr.GetLength(0) || a > arr.GetLength(1))
                Console.WriteLine("Такого элемента не существует ");
            else Console.WriteLine($"Элемент строки {a} и столбца {b} равен {arr[a - 1, b - 1]}");

}

int[,] matrix = CreateMatrixRndInt(4, 5);
PrintMatrix(matrix);
Console.WriteLine();
FindMatrixElement(matrix, num1, num2);

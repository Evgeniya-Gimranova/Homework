// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int m, int n)
{
    double [,] array = new double [m, n];
    // var rnd = new Random.NextDouble();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
    return array ;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) -1 ) Console.Write(arr[i, j] + " , ");
            else Console.Write(arr[i, j] + " ] ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrixRndInt(3, 4);
PrintMatrix(matrix);

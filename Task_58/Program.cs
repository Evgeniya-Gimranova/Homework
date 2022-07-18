// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк первой матрицы ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк первой матрицы ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы ");
int num4 = Convert.ToInt32(Console.ReadLine());
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
int[,] firstMatrix = CreateMatrixRndInt(num1, num2, minElement, maxElement);
int[,] secondMatrix = CreateMatrixRndInt(num3, num4, minElement, maxElement);


void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + " , ");
            else Console.Write(arr[i, j] + " ] ");
        }
        Console.WriteLine();
    }
}

int[,] resMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

if (num2==num3) MultiplyMatrix(firstMatrix, secondMatrix, resMatrix);
else Console.WriteLine("Невозможно перемножить матрицы");
Console.WriteLine();

void MultiplyMatrix(int[,] arr1, int[,] arr2, int[,] newArr)
{

    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            newArr[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++) 
                newArr[i, j] = newArr[i, j] + arr1[i, k] * arr2[k, j];
        }
    }
}

PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine();
PrintMatrix(resMatrix);





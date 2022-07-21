// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

int n = 4;
int[,] matrix = new int[n, n];

void SpiralMatrix(int [,]arr2)
{
int num = 1;
int i = 0;
int j = 0;

while (num <= arr2.GetLength(0) * arr2.GetLength(1))
{
  arr2[i, j] = num;
  num++;
  if (i <= j + 1 && i + j < arr2.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arr2.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arr2.GetLength(1) - 1)
    j--;
  else
    i--;
}
}
SpiralMatrix(matrix);

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ", ");
            else Console.Write(arr[i, j] );
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);
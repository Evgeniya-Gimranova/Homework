// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] array = new[] { 3.6, 8.2, 1.8, 2.7, 9.5 };
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(" [ ");
        if (i < arr.Length - 1) Console.Write(arr[i] + "  ");
        else Console.Write(arr[i] + " ] ");

    }
}
PrintArray(array);
Console.WriteLine();

double FindMaxElement(double[] arr)
{
    double maxElement = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement)
            maxElement = arr[i];
    }
    return maxElement;
}
double maxNum = FindMaxElement(array);
Console.WriteLine($"Максимальное число в массиве равно {maxNum}");

double FindMinElement(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
            minElement = arr[i];
    }
    return minElement;
}
double minNum = FindMinElement(array);
Console.WriteLine($"Минимальное число в массиве равно {minNum}");

double FindSubtractionMaxMinNums(double[] arr)
{
    double sub = maxNum - minNum;
    return sub;
}
double subtraction = FindSubtractionMaxMinNums(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {subtraction} ");
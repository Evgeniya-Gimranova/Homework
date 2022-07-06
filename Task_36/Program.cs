// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;
    while (index < array.Length)
    {
        array[index] = rnd.Next(1, 11);
        index++;
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + " , ");
        else Console.Write(arr[i] + " ] ");

    }
}

int[] array1 = CreateArrayRndInt(5);

PrintArray(array1);

int FindSumOddIndex(int[] array2)
{
    int sum = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array2[i];
    }
    return sum;
}
int sum2 = FindSumOddIndex(array1);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum2}");


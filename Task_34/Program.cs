// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;
    while (index < array.Length)
    {
        array[index] = rnd.Next(100, 1000);
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

int[] array1 = CreateArrayRndInt(8);

PrintArray(array1);

int FindEvenNumber(int[] arr1)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 == 0) 
        count++;
    }
    // while (i < arr1.Length)
    // {
    //     if (arr1[i] % 2 == 0) ;
    //     count = count + 1;
    //     i++;
    // }
    return count;
}
int count1 = FindEvenNumber(array1);
Console.WriteLine();
Console.WriteLine($"количество четных чисел в массиве равно {count1} ");
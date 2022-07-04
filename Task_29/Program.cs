// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] array= new int[8];
int index = 0;
Random rnd = new Random();
while (index <array.Length)
{
    array[index]= rnd.Next(0,99);  
    index ++;
}

for (int i = 0; i < array.Length; i++)
{
    if (i == 0) Console.Write(" [ ");
    if (i<array.Length - 1) Console.Write(array [i] + " , ");
    else Console.Write(array[i] + " ] ");
}
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[,,] Create3DMassivRndInt(int num1, int num2, int num3)
{
    int[,,] array = new int[num1, num2, num3];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

int [,,]volumMassive = Create3DMassivRndInt(2, 2, 2);

void Print(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)

            {
                Console.WriteLine($"[{i},{j},{k}] - {arr[i, j, k]}");
            }
            Console.WriteLine();
        }
    }
}
Print(volumMassive);
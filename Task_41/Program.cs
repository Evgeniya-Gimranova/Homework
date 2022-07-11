// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел, которое будет вводиться с клавиатуры ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int i = 0; i < num; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int CountPositiveInt(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }
    return result;
}
int count = CountPositiveInt(array);

Console.WriteLine($"Количество положительных чисел равно {count}");




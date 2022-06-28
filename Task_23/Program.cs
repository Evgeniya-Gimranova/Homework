// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
void GetCube(int a)
{
    int i = 1;
    while (i <= a)
    {
        int cube = i * i * i;
        Console.WriteLine($"Таблица кубов {cube}");
        i++;
    }
}
GetCube(num);

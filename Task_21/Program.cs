// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1 ");
int a1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2 ");
int a2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1 ");
int b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int b2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1 ");
int c1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2 ");
int c2=Convert.ToInt32(Console.ReadLine());

double GetDistance(int a1, int a2, int b1, int b2, int c1, int c2)
{
    double res = Math.Sqrt((a2-a1)*(a2-a1)+ (b2-b1)*(b2-b1)+(c2-c1)*(c2-c1));
    res=Math.Round(res, 2);
    return res;
}
double result= GetDistance(a1, a2, b1, b2, c1, c2);
Console.WriteLine(result);

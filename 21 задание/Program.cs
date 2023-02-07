//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();




Console.Write("Введите координат Х1: ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координат Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координат Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координат Х2: ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координат Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координат Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);

double sumX = Math.Pow(X2-X1, 2);
double sumY = Math.Pow(Y2-Y1, 2);
double sumZ = Math.Pow(Z2-Y1, 2);

double num = Math.Sqrt(sumX+sumY+sumZ);
num = Math.Round(num, 2);
Console.WriteLine(num);
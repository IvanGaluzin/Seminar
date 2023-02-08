// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();


Console.Write("Введите координаты точки A x: ");
int Ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки A y: ");
double Ay = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координаты точки A z: ");
int Az = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки B x: ");
double Bx = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координаты точки B y: ");
double By = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Введите координаты точки B z: ");
double Bz = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2);

double len = Math.Sqrt(x);



Console.WriteLine($"Растояние В 3D пространсве: {len:f2}");
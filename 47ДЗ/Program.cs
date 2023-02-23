// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 

Console.Clear();

double[,] GetArray2D(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    return result;
}
void PrintArray2D(double[,] Array2D)
{
    for (int i = 0; i < Array2D.GetLength(0);i++)
    {
        for (int j = 0; j < Array2D.GetLength(1); j++)
        {
            Console.Write($"{Array2D[i,j]:f1}\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите высоту массива:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите ширину массива:");
int n = int.Parse(Console.ReadLine()!);
double[,] myArray2D = GetArray2D(m, n, -10, 10);
PrintArray2D(myArray2D);

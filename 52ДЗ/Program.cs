// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray2D(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray2D(int[,] inArray2D)
{
    for (int i = 0; i < inArray2D.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2D.GetLength(1); j++)
        {
            Console.Write($" {inArray2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

string GetAverageArray2D(int[,] inArray2D)
{
    string result = "";
    double sum;
    double average;
    for (int i = 0; i < inArray2D.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < inArray2D.GetLength(0); j++)
        {
            sum += inArray2D[j, i];
        }
        average = sum / inArray2D.GetLength(0);
        result += $"{average:f1}\t ";
    }
    result += "cреднее арифметическое";
    return result;
}
Console.Clear();
int[,] inArray2D = GetArray2D(3, 4, 0, 9);
PrintArray2D(inArray2D);
Console.Write(GetAverageArray2D(inArray2D));
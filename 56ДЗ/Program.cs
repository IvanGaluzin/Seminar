// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ArrayMinSum (int[,] array2D)
{
    int iLine = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum = sum + array2D[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            iLine++;
        }
        
    }
    Console.Write($"Наименьшая сумма у {iLine} строки");
}

Console.Clear();
int[,] array2D = GetArray(4, 3, 0, 9);
PrintArray(array2D);
Console.WriteLine();
ArrayMinSum(array2D);

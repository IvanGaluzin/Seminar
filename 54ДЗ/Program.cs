// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

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
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void Array2DSortToLower(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array2D.GetLength(1) - 1; z++)
            {
                if (array2D[i, z] < array2D[i, z + 1])
                {
                    int temp = 0;
                    temp = array2D[i, z];
                    array2D[i, z] = array2D[i, z + 1];
                    array2D[i, z + 1] = temp;
                }
            }
        }
    }
}

Console.Clear();
int[,] array2D = GetArray(3, 3, -10, 10);
PrintArray(array2D);
Console.WriteLine();
Array2DSortToLower(array2D);
PrintArray(array2D);
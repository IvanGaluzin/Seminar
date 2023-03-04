// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MultMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Матрицы невозможно умножить!");
        return matrixC;
    }
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }

        }
    }
    return matrixC;
}

Console.Clear();

Console.Write("Введите размерность MA через запятую: ");
int[] dimensionA = Array.ConvertAll(Console.ReadLine()!.Split(','), Convert.ToInt32);
int[,] matrixA = GMatrix(dimensionA[0], dimensionA[1], 0, 9);

Console.Write("Введите размерность MB через запятую: ");
int[] dimensionB = Array.ConvertAll(Console.ReadLine()!.Split(','), Convert.ToInt32);
int[,] matrixB = GMatrix(dimensionB[0], dimensionB[1], 0, 9);

PMatrix(matrixA);
Console.WriteLine();
PMatrix(matrixB);

int[,] matrixC = MultMatrix(matrixA, matrixB);
Console.WriteLine();
PMatrix(matrixC);
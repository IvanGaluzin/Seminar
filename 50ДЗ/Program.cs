// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1 ; 7] -> такой позиции нет

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
            Console.Write($"{inArray2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}


string FindArray2D(int m, int n, int[,] inArray2D)
{
    if (m < 0 || n < 0) return "m и n должны быть натуральными";
    string result;
    if (m <= inArray2D.GetLength(0) - 1 && n <= inArray2D.GetLength(1) - 1)
    {
        result = $"[{m} ; {n}] -> {inArray2D[m, n]}";
    }
    else
    {
        result = $"[{m} ; {n}] -> такой позиции нет";
    }
    return result;
}
Console.Clear();
int[,] inArray2D = GetArray2D(3, 4, 0, 10);
PrintArray2D(inArray2D);
Console.Write("Позицию через пробел: ");
string[] s = Console.ReadLine()!.Split();
int m = Convert.ToInt32(s[0]);
int n = Convert.ToInt32(s[1]);
Console.Write(FindArray2D(m, n, inArray2D));
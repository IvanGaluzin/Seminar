// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size, double MinValue, double MaxValue)
{
    double[] Res = new double[size];
    for (int i = 0; i < size; i++)
    {
        Res[i] = new Random().NextDouble() * (MaxValue - MinValue) + MinValue;
    }
    return Res;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:f2}  ");
    }
    Console.Write($"{array[array.Length - 1]:f2}");
    Console.WriteLine("]");
}

double[] array = GetArray(5, 100, 999);
PrintArray(array);

double FMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

Console.Write($"Максимальное {FMax(array):f2}");
Console.WriteLine($" - Минимальное {FMin(array):f2}");
double diff = FMax(array) - FMin(array);
Console.Write($"Разница {diff:f2}");
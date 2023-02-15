// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Res = new int[size];

    for (int i = 0; i < size; i++)
    {
        Res[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Res;
}
int Even(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) res++;
    }
    return res;
}

int[] array = GetArray(5, 100, 999);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");
int res = Even(array);
Console.Write($" -> {res}");
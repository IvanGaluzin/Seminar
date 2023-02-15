// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int SumN(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}
int[] array = GetArray(5, -999, 999);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");
int res = SumN(array);
Console.Write($" -> {res}");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33-> [6, 1, 33]

Console.Clear();

int[] GenArr(int len, int min, int max)
{
    int[] array = new int[len];
    Random random = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}
void PrArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
Console.Write("Длина массива: ");
int len = int.Parse(Console.ReadLine()!);
Console.Write("Минимальное значение случайного числа: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Максимальное значение случайного числа: ");
int max = int.Parse(Console.ReadLine()!)+1;
int[] array = GenArr(len,min,max);
PrArr(array);
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetPozitive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

Console.Write("Введите размер масива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, -99, 99);
Console.WriteLine(String.Join(", ", array));
if (GetPozitive(array) == 0)
{
    Console.Write($"Чисел больше 0 : Нет ");
}
else
{
    Console.Write($"Чисел больше 0 : {GetPozitive(array)}");
}
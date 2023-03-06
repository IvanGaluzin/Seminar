// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumberSum(int m, int n)
{
    int res = m;
    if (m == n) return m;
    m++; res = res + NumberSum(m, n);
    return res;
}
Console.Write("Введите число M = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N = ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных чисел: {NumberSum(m, n)}");
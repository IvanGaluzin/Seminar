// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число: " );
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: " );
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: " );
int c = int.Parse(Console.ReadLine()!);

int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max > c)
{
    Console.Write($"Максимальное из трех {max}");
}
else
{
    max = c;
    Console.Write($"Максимальное из трех {max}");
}
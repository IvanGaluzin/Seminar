// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Введите первое число: " );
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: " );
int b = int.Parse(Console.ReadLine()!);

int max = 0;
int min = 0;

if (a > b)
{
   max = a;
   min = b;
}
else 
{
   max = b;
   min = a;
}

Console.WriteLine($"Максимальное число {max}");
Console.WriteLine($"Минимальное число {min}");

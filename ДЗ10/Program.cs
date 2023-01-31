// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.

Console.Clear();

Console.Write("Введите трех значное число: ");
int num = int.Parse(Console.ReadLine()!);

int a1 = num / 100;
int a2 = num % 10;

int b = (num - (a1 * 100 + a2)) / 10;
if(num < 99 || num > 1000)
{
    Console.Write("Введите трех значное число");
}
else
{
    Console.WriteLine($"Вторая цифра числа {b}");
}

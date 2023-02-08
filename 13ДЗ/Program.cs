// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int a = num % 10;

if(num < 99)
{
    Console.Write("Третьего числа нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {a}");
}
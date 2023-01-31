// Задача №16. Работа в группах
// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет

Console.Clear();

Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
if (b * b == a || a * a == b)
{
Console.Write("Да");
}
else
{
Console.Write("Нет");
}
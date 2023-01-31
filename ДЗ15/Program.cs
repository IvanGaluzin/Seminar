// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.

Console.Clear();

   Console.Write("Введите номер дня недели: ");
   int num = int.Parse(Console.ReadLine()!);
   if (num == 1 || num == 2 ||num == 3 || num == 4 || num == 5)
   {
       Console.WriteLine("нет");
   }
   else if (num == 7 || num == 6)
   {
       Console.WriteLine("да");
   }
   else
   {
       Console.WriteLine("Введите другое число");
   }
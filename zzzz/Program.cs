using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 13, 24, 35, 46, 57, 68, 79, 80 }; // создаем массив с числами

        int[,,] arr3d = new int[2, 2, 2]; // создаем трехмерный массив

        // заполняем трехмерный массив из спискаvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
        for (int i = 0; i < arr.Length; i++)
        {
            int x = i / 4;
            int y = (i / 2) % 2;
            int z = i % 2;
            arr3d[x, y, z] = arr[i];
        }

        // выводим массив с индексами
        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                for (int z = 0; z < 2; z++)
                {
                    Console.Write($"{arr3d[x, y, z]:00}({x},{y},{z}) ");
                }
                Console.WriteLine();
            }
        }
    }
}
// В данном примере мы используем язык C#, создаем трехмерный массив arr3d, заполняем его из списка arr и выводим его с индексами на консоль с помощью вложенных циклов.
int a = 2;
int b = 0;
int c = 0;
int[][] arr = new int[3][];

arr[0] = new int[3] { 1, 2, 3 };
arr[1] = new int[3] { 4, 5, 6 };
arr[2] = new int[3] { 7, 8, 9 };

Console.WriteLine($" {arr[0][0]}, {arr[0][1]}, {arr[0][2]}");
Console.WriteLine($" {arr[1][0]}, {arr[1][1]}, {arr[1][2]}");
Console.WriteLine($" {arr[2][0]}, {arr[2][1]}, {arr[2][2]}");
Console.Write("Начиная с 7 против часовой стрелки: ");
while (c < 9)
{
    Console.Write($" {arr[a][b]}");
    if (b < 2 && c < 2)
    {
        b++;
    }
    if (a > -1 && c > 1 && c < 4)
    {
        a--;
    }
    if (b > 0 && c > 3 && c < 6)
    {
        b--;
    }
    if (a < 1 && c > 5 && c < 8)
    {
        a++;
    }
    if (b < 2 && c > 6)
    {
        b++;
    }
    c++;
}

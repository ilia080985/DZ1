// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int a = i % 2;
while (i < num)
{
    if (a > 0)
    {
        i++;
    }
    else if (a == 0)
    {
        Console.Write($"{i}");
        i++;
    }
}
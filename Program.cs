// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числo a");
Console.WriteLine("Введите два числo b");
 int num_1=Convert.ToInt32(Console.ReadLine());
 int num_2=Convert.ToInt32(Console.ReadLine());

   int max =num_1;
   int min =num_2;
if (num_1>num_2){
   max =num_1;
    min =num_2;
}
else{
    max = num_2;
    min = num_1;
    }
Console.WriteLine($"большее число {max}");
Console.WriteLine($"меньшее число {min}");
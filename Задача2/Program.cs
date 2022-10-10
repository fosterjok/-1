//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

int a;
int b;

Console.WriteLine ("Введите число 1:");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine ("Введите число 2:");
int.TryParse(Console.ReadLine(), out b);

if ( a>b) 
{
    Console.Write($"Максимальное число= {a} ");
}

else 
{
      Console.Write($"Максимальное число= {b} ");
}


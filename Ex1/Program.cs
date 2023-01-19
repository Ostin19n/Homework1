// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3
Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
int max, min;
if (a > b)
{
    max=a;
}
else {
    max = b;
}
if (a < b)
{
    min = a;
}
else 
{
    min = b;
}
Console.WriteLine("Большее число " + max);
Console.WriteLine("Меньшее число  " + min);

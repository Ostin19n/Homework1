﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int c = int.Parse(Console.ReadLine());
int max;
if (a > b)
{
    max = a;
}
else {
    max = b;
}
if (c > max);
{
    max = c;
}

Console.WriteLine("Максимальное число " + max);
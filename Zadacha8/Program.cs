﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
while (a <= N)
{    Console.Write(a + " ");
    a = a + 2;
}

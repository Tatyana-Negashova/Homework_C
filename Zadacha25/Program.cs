﻿// Напишите функцию, которая принимает на вход два числа и
// возводит число А в степень Б.

System.Console.WriteLine("Введите число, возводимое в степень: ");
int A = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите степень: ");
int С = int.Parse(Console.ReadLine()!);

void Exponentiation(int a, int b)
{
    for (int i = 1; i < b; i++)
    {
        a *= A;
    }
    System.Console.WriteLine(a);
}

Exponentiation(A, С);

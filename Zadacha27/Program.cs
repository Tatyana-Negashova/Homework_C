﻿// Напишите функцию, которая принимает на вход число и выдает
// сумму цифр в числе.

System.Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);

void Summa(int a)
{
    int temp = 0;
    for (; a > 0; a /= 10)
    {
        temp += a % 10;
    }
    System.Console.WriteLine(temp);
}

Summa(Number);


// See https://aka.ms/new-console-template for more information
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите число: ");
int i = int.Parse (Console.ReadLine ()!);
int j = 1;

while (j <= i)
{
    Console.Write ($"{j*j},");
    j ++;
}
Console.Write("\b \b");


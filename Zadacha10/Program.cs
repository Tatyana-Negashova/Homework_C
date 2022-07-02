// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int b = (number / 10) % 10;
if (number < 100 || number > 999)
{
    Console.WriteLine("Некорректные данные");
}
else
{
    Console.WriteLine("{0} - второе число", b);
}

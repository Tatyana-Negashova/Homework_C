//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{ System.Console.WriteLine(a + "-четное число"); }
else
{ System.Console.WriteLine(a + "-нечетное число"); }



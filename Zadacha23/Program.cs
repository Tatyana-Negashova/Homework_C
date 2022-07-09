//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
int cube = 1;
while (i <= N)
{
    cube = i * i * i;
    Console.Write($"{cube},");
    i++;
}
System.Console.WriteLine("\b \b");

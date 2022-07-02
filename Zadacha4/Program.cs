/// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c;
int max = 0;
Console.WriteLine("Введите три числа ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
max = (Math.Max(a, Math.Max(b, c)));
Console.WriteLine("{0} - максимальное число", max);



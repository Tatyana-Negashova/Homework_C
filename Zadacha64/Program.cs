// Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 303

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
void SumNumbers(int M, int N, int sum = 0)
{
    if (M == N)
    {
        System.Console.WriteLine(sum + M);
        return;
    }
    SumNumbers(M + 1, N, sum + M);
}
SumNumbers(M, N);


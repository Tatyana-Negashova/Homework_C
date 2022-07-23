/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


Console.WriteLine("Введите количество строк массива:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int lines, int columns)
{
    Random rnd = new Random();
    int[,] mtrx = new int[lines, columns];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(11);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            Console.Write($"{mtrx[i, j],2} | ");
        }
        Console.WriteLine("");
    }
}

void SearchMinSumLine (int[,] mtrx)
{
    int count = 0;
    
    int[] temp = new int[mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            count += mtrx[i, j];
        }
        temp[i] = count;
        count = 0;
    }
    int min = temp[0];
    int mintemp = 0;
    for (int i = 1; i < temp.Length; i++)
    {
        if (temp[i] <= min) 
        {
            min = temp[i];
            mintemp = i;
        }
    }
    Console.WriteLine($"Строка массива с наименьшей суммой элементов - № {mintemp + 1}.");
}

int[,] arr = GetMatrix(lines, columns);
Console.Clear();
PrintMatrix(arr);
Console.WriteLine();
SearchMinSumLine(arr);

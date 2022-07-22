/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] GetMatrix(int rows, int columns, int minNumber, int maxNumber)
{
    int[,] matrix = new int[rows, columns];

    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minNumber, maxNumber);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{matrix[i, j], 1} | ");
        }
        Console.WriteLine();
    }
}
void AverageOfColumns(int[,] matrix)
{
    double sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }

        if (j == 0) Console.WriteLine("Среднее арифметическое по столбцам:");
        Console.WriteLine($" {Math.Round(sum / matrix.GetLength(0), 2)}");

        sum = 0;
    }
}

int[,] array = GetMatrix(rows, colums, 0, 100);
PrintMatrix(array);
Console.WriteLine();
AverageOfColumns(array);
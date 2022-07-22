/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

System.Console.Write("Введите число строк: ");
int rows = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] GetMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = rnd.NextDouble()*10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{arr[i, j],1} | ");
        }
        Console.WriteLine();
    }
}

double[,] arr = GetMatrix(rows,columns);
                          
PrintMatrix(arr);
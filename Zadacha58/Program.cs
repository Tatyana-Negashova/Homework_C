/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

Console.WriteLine("Введите количество строк матрицы");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] MatrixFirst = new int[lines, columns];
int[,] MatrixSecond = new int[lines, columns];
int[,] MatrixMultiplication = new int[lines, columns];
Random r = new Random();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
}
void Multiplication(int[,] MatrixMultiplication)
{
    int sum = 0;
    for (int i = 0; i < MatrixMultiplication.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixMultiplication.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < MatrixMultiplication.GetLength(0); k++)
            {
                sum += MatrixFirst[i, k] * MatrixSecond[k, j];
            }
            MatrixMultiplication[i, j] = sum;
        }
    }
}
FillArray(MatrixFirst);
Console.WriteLine($"Первая матрица:");
PrintArray(MatrixFirst);
FillArray(MatrixSecond);
 Console.WriteLine();
Console.WriteLine($"Вторая матрица:");
PrintArray(MatrixSecond);
Multiplication(MatrixMultiplication);
Console.WriteLine();
Console.WriteLine($"Произведение двух заданнных матриц:");
PrintArray(MatrixMultiplication);


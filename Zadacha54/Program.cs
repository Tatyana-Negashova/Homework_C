/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

Console.WriteLine("Введите количество строк массива: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, columns];
FillArrayRandomNumbers(numbers);

Console.WriteLine("Получившийся массив: ");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < numbers.GetLength(1) - 1; k++)
        {
            if (numbers[i, k] < numbers[i, k + 1]) 
            {
                int temp = 0;
                temp = numbers[i, k];
                numbers[i, k] = numbers[i, k + 1];
                numbers[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив со значениями по убыванию:");
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}
Console.WriteLine();
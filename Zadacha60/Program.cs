/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)*/

Console.Clear();
Console.WriteLine("Введите количество строк трёхмерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов трёхмерного массива");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество слоёв трёхмерного массива");
int layers = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = new int[rows, columns, layers];
Random r = new Random();

void FillArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = r.Next(0, 100);
            }
        }
    }
}
void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k],4}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
FillArray3d(array3d);
Console.WriteLine();
Console.WriteLine($"Массив с индексами элементов:");
PrintArray3d(array3d);

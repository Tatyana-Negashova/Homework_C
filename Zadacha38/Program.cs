// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] Collection = new double[10];
for (int i = 0; i < Collection.Length; i++)
{
    Collection[i] = new Random().Next(1, 100);
    Console.Write(Collection[i] + " ");
}
double max = Collection[0];
double min = Collection[0];

for (int i = 1; i < Collection.Length; i++)
{
    if (max < Collection[i])
    {
        max = Collection[i];
    }
    if (min > Collection[i])
    {
        min = Collection[i];
    }
}
double diff = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами равна {diff}.");
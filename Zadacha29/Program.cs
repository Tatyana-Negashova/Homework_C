// Напишите программу, которая задает массив из некоторого количества
// элементов и выводит их на экран с помощью функций


int[] Collection(int elements)
{
    int[] collection = new int[elements];
    Console.WriteLine("Заполните массив: ");

    for (int i = 0; i < collection.Length; i++)
    {
        Console.WriteLine();
        Console.Write($"Введите элемент массива № {i}: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Числа массива: ");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");

    }
    return collection;
}
Console.Write("Введите длину массива: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());


Collection(SizeArray);



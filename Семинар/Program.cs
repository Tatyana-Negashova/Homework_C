//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Void printDiapason(float x)
{
    if (x == 1)
    {
        System.Console.WriteLine("Х положительный");
        System.Console.WriteLine("Y положительный");
    }
    else if (x == 2)
    {
        System.Console.WriteLine("Х отрицательный");
        System.Console.WriteLine("Y положительный");
    }
    else if (x == 3)
    {
        System.Console.WriteLine("Х отрицательный");
        System.Console.WriteLine("Y отрицательный");
    }
    else if (x == 4)
    {
        System.Console.WriteLine("Х положительный");
        System.Console.WriteLine("Y отрицательный");
    }

    else
        System.Console.WriteLine("Некорректный ввод данных");
}
printRangeXY(4);




void printPlanesNumber(float x, float y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Плокскость 1");
    else if (x < 0 && y > 0)
        Console.WriteLine("Плокскость 2");
    else if(x < 0 && y < 0)
        Console.WriteLine("Плокскость 3");
    else if(x > 0 && y < 0)
        Console.WriteLine("Плокскость 4");
    else
        Console.WriteLine("Некорректные входные данные!!!");
}
           
printPlanesNumber(6, 2);
Console.WriteLine();

int getPlanesNumber(float x, float y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}


int planesNumber = getPlanesNumber(-1, 0);
if (planesNumber != -1 )
    Console.WriteLine($"Плоскость {planesNumber}");
else
    Console.WriteLine("Некорректные входные данные!!!");




int a,b,c;
int max = 0;
Console.WriteLine("Введите три числа ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
    if (a>b) max = a;
    else max = b;

    if (b<c) max = c;
    else max = b;
System.Console.WriteLine("{0} - максимальное число", max);
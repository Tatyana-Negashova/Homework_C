// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Weekends(int day)
{
    if (day < 1 || day > 7)
    {
        Console.WriteLine("Введены некорректные данные");
    }
    else if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());
Weekends(num);

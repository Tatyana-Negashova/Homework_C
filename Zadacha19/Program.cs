//Напишите программу которая принимает на вход птятизначное число
// и проверяет является ли оно палиндромом.

 Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
if (number[0] == number[4] && number[1] == number[3])
{
    System.Console.WriteLine("Является полиндромом.");
}
else
{
    System.Console.WriteLine("Не является полиндромом.");
}



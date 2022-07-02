/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/


LengthBetweenPoints(x1, y1, x2, y2);

printGipotenuza(double ax, double ay, double bx, double by);
{
    double deltaX = ax - bx;
    double deltaY = ay - by;
    double c = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    System.Console.WriteLine(c);
}
PrintGiptenuza(7,-5,1,-1);


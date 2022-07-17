// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] coefficients = new double[2, 2];
double[] crossPoint = new double[2];

void Coefficients()
{
    for (int i = 0; i < coefficients.GetLength(0); i++)
    {
        Console.Write($"Введите координаты для {i + 1}-го уравнения (y = k * x + b):\n");
        for (int p = 0; p < coefficients.GetLength(1); p++)
        {
            if (p == 0) Console.Write($"Введите значение координаты k: ");
            else Console.Write($"Введите значение коориданты b: ");
            coefficients[i, p] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] IntersectionPoint(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}

void PrintAnswer(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"\nПрямые совпадают");
    }
    else if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
    {
        Console.Write($"\nПрямые параллельны");
    }
    else
    {
        IntersectionPoint(coeff);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

Coefficients();
PrintAnswer(coefficients);


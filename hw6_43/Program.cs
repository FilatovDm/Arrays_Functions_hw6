/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] GetCrossPoint(double k1, double b1, double k2, double b2)
{
    double[] pointCoord = new double[2];

    pointCoord[0] = (b2 - b1) / (k1 - k2);
    pointCoord[1] = k2 * pointCoord[0] + b2;

    return pointCoord;
}

Console.Write("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var pointCoordinates = GetCrossPoint(k1, b1, k2, b2);
Console.WriteLine("Координаты точки пересечения: ({0})", string.Join("; ", pointCoordinates));

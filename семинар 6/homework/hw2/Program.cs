/*Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("ищем точку пересечения уравнений:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine();
double k1; double b1; double k2; double b2; /*жаль, что в цикле нельзя объявить :(*/
while (true) //проверим ввод
{
    try
    {
        Console.Write("Задайте коэффициент k1: ");
        k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Задайте коэффициент b1: ");
        b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Задайте коэффициент k2: ");
        k2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Задайте коэффициент b2: ");
        b2 = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("заново");
    }
}

try
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.WriteLine($"Прямые пересекаются в точке с координатами x = {x}, y = {y}");
}
catch (System.Exception)
{
    Console.WriteLine("при введённых коэффициентах система не имеет решений");
}

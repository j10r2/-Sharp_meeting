Console.WriteLine("введите длину 1-й стороны треугольника");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("введите длину 2-й стороны треугольника");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("введите длину 3-й стороны треугольника");
int c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("треугольник с такими сторонами существовать может");
}
else
{
    Console.WriteLine("треугольник с такими сторонами не существует");
}
Console.WriteLine("введите координаты 2-х точек");
int count = 0;
while (count < 10)
{
    try
    {
        int i = 1;
        Console.Write($" x {i}-й точки:");
        int xa = int.Parse(Console.ReadLine());
        Console.Write($"y {i}-й точки:");
        int ya = int.Parse(Console.ReadLine());
        Console.Write($"z {i}-й точки:");
        int za = int.Parse(Console.ReadLine());
        i++;
        Console.Write($"x {i}-й точки:");
        int xb = int.Parse(Console.ReadLine());
        Console.Write($"y {i}-й точки:");
        int yb = int.Parse(Console.ReadLine());
        Console.Write($"z {i}-й точки:");
        int zb = int.Parse(Console.ReadLine());
        double length = Math.Pow((Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)), 1 / 2.0);

        Console.Write($"длина отрезка равна {Math.Round(length, 2)}");
        break;
    }
    catch
    {
        count++;
        if (count < 10)
        {
            Console.Write("фигня какая-то, попробуй ещё раз");
            if (count == 9)
            {
                Console.WriteLine(", последний шанс.");
            }
        }
        else
        {
            Console.WriteLine("Свободен. Следующий.");
        }
    }
}
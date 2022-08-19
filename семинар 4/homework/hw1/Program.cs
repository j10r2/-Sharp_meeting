Console.WriteLine("Введите число A");
int tries = 5;
int count = 0;
while (count < tries)
{
    try
    {
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число B (натуральное (натуральное - это целое и больше 0))");
        int b = int.Parse(Console.ReadLine());
        if (b == 1)
        {
            Console.WriteLine($"число {a} в степени {b} равно {a}");
        }
        else
        {
            double prod = a;
            for (int i = 2; i <= b; i++)
            {
                prod *= a;
            }
            Console.WriteLine($"число {a} в степени {b} равно {prod}");
        }
        break;
    }
    catch
    {
        if (count == tries - 1)
        { Console.WriteLine($"Приплыли, суши вёсла");}
        else
        { Console.WriteLine($"Попробуй ещё раз"); }
        count++;
    }
}
try
    {
        Console.WriteLine("Введите целое число (с дробным лень заморачиваться):");
        int a = Math.Abs(int.Parse(Console.ReadLine()));
        int sum = 0;
        while (a > 99)
        {
            sum = sum + a % 10;
            a = a / 10;
        }
        sum = sum + a % 10 + a / 10;
        Console.WriteLine($"сумма цифр введённого числа равна {sum}");
    }
    catch
    {
        Console.WriteLine();
        Console.WriteLine($"Учительница сказала, что ты не знаешь математики, и нарисовала в дневнике какую-то закорючку");
    }
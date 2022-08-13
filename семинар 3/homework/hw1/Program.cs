System.Console.WriteLine("Введите произвольное целое число");
int count = 0;
int trys = 3;
while (count < trys)
{
    try
    {
        int x = int.Parse(Console.ReadLine());
        string sx = Convert.ToString(x);
        int length = sx.Length;
        int sum = 0;
        int z;
        int y;
        for (int i = 1; sum < 1 && i <= (length / 2); i++)
        {
            z = int.Parse(sx.Substring(i - 1, 1));
            y = int.Parse(sx.Substring(length - i, 1));
            if (z == y)
            { }
            else { sum++; }
        }
        if (sum == 0)
        {
            Console.WriteLine("введённое число является палиндромом");
        }
        else
        {
            Console.WriteLine("введённое число не является палиндромом");
        }
        break;
    }
    catch
    {
            if (count == trys-1)
            {
                Console.WriteLine("game over");
            }
            else
            {Console.WriteLine($"введено что-то непонятное, осталось попыток: {trys - (count + 1)}");}   
            count ++;         
    }
}
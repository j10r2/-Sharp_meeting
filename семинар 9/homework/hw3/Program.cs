/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29*/


int N;
int M;
while (true)
    try
    {
        Console.WriteLine("введите целое число M (от 0 и выше)");
        M = int.Parse(Console.ReadLine());
        Console.WriteLine("введите целое число N (от 0 и выше)");
        N = int.Parse(Console.ReadLine());
        if (M >= 0 && N >= 0) break;
        else
        {
            Console.WriteLine("Больше или равно.");
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Введена какая-то фигня");
    }

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m > 0) && (n == 0))
        {
            return AckermanFunction(m - 1, 1);
        }
        else
        {
            return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
        }
    }
}

Console.WriteLine(AckermanFunction(M, N));
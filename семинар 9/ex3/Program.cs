int N;
int M;
while (true)
    try
    {
        Console.WriteLine("введите число");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("введите степень");
        M = int.Parse(Console.ReadLine());
        if (N <= 0 || M <= 0) Console.WriteLine("натуральные числа - это целые и больше ноля.");
        if (N == M) Console.WriteLine("Числа не должны быть равны.");
        if (N > 0 && M > 0 && N != M) break;
    }
    catch (System.Exception)
    {
        Console.WriteLine("Введена какая-то фигня");
    }

int RecursivePow(int foundation, int degree)
{
    if (degree == 1) return foundation;
    else return RecursivePow(foundation, degree - 1) * foundation;

}

Console.WriteLine($"{N} в степени {M} равно {RecursivePow(N, M)}");
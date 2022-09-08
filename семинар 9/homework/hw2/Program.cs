/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N (используйте рекурсию).

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int N;
int M;
while (true)
    try
    {
        Console.WriteLine("введите натуральное число N");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("введите натуральное число M");
        M = int.Parse(Console.ReadLine());
        if (N <= 0 || M <= 0) Console.WriteLine("натуральные числа - это целые и больше нуля.");
        if (N == M) Console.WriteLine("Числа не должны быть равны.");
        if (N > 0 && M > 0 && N != M) break;
    }
    catch (System.Exception)
    {
        Console.WriteLine("Введена какая-то фигня");
    }


int RecursiveSumOfInterval(int startNumber, int finishNumber)
{
    if (startNumber == finishNumber) return startNumber;
    else return RecursiveSumOfInterval(startNumber - 1, finishNumber) + startNumber;
}

if (M > N) Console.WriteLine(RecursiveSumOfInterval(M, N));
else Console.WriteLine(RecursiveSumOfInterval(N, M));
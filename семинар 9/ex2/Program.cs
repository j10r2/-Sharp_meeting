/* Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.*/

int N;
int M;
while (true)
    try
    {
        Console.WriteLine("введите натуральное число N");
        N = int.Parse(Console.ReadLine());
        Console.WriteLine("введите натуральное число M");
        M = int.Parse(Console.ReadLine());
        if (N <= 0 || M <= 0) Console.WriteLine("натуральные числа - это целые и больше ноля.");
        if (N == M) Console.WriteLine("Числа не должны быть равны.");
        if (N > 0 && M > 0 && N != M) break;
    }
    catch (System.Exception)
    {
        Console.WriteLine("Введена какая-то фигня");
    }


void NaturalNumbers(int finishNumber, int startNumber)
{
    Console.Write(startNumber);
    if (startNumber < finishNumber) Console.Write(", ");
    startNumber++;
    if (startNumber <= finishNumber) NaturalNumbers(finishNumber, startNumber);
    else return;
}

if (M > N) NaturalNumbers(M, N);
else NaturalNumbers(N, M);
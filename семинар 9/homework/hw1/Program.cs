/* Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1 (используйте рекурсию).
N = 5 -> 5, 4, 3, 2, 1 */

int N;
while (true)
    try
    {
        Console.WriteLine("введите число N больше единицы");
        N = int.Parse(Console.ReadLine());
        if (N <= 1) Console.WriteLine("больше - значит БОЛЬШЕ, хотя бы 2");
        else break;
    }
    catch (System.Exception)
    {
        Console.WriteLine("Это не число.");
        Console.WriteLine("Мне нужно число.");
    }


void RecursiveNumbers(int counter)
{
    Console.Write(counter);
    if (counter-1 >= 1) Console.Write(", ");
    if (counter == 1) return;
    RecursiveNumbers(counter-1);
}

RecursiveNumbers(N);
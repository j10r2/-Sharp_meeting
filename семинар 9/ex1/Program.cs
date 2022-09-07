/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.*/

double N;
while (true)
    try
    {
        Console.WriteLine("введите число N");
        N = double.Parse(Console.ReadLine());
        break;
    }
    catch (System.Exception)
    {
        Console.WriteLine("Ты ввёл не число.");
        Console.WriteLine("Введи число.");
    }


void NaturalNumbers(double extreme, int counter)
{
    Console.Write(counter);
    if (counter < extreme) Console.Write(", ");
    counter++;
    if (counter <= extreme / 1) NaturalNumbers(extreme, counter);
    else return;
}

NaturalNumbers(N, 1);
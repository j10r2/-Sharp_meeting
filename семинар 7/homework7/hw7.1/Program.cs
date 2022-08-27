//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10) + Math.Round((new Random().NextDouble()), 2);
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
            if (j < arr.GetLength(1) - 1) Console.Write(" | ");
        }
        Console.WriteLine();
    }
}

int m;
int n;
try
{
    Console.WriteLine("введите высоту массива");
    m = Math.Abs(int.Parse(Console.ReadLine())); //перехитрим юзера, который пытается ввести отрицательное число
    Console.WriteLine("введите длину массива");
    n = Math.Abs(int.Parse(Console.ReadLine()));
    if (m == 0 || n == 0) Console.WriteLine("ну и как ты себе представляешь этот массив?");
    else
    {
        double[,] array = new double[m, n];
        FillArray(array);
        PrintArray(array);
    }
}
catch
{
    Console.WriteLine("когда-нибудь у тебя получится");
}
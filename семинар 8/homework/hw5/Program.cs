/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int UlitkaFilling(int[,] arr, int i, int j, int start)
{
    while (j < arr.GetLength(1))
    {
        if (arr[i, j] == 0)
        {
            arr[i, j] = start;
            start++;
            j++;
        }
        else break;
    }
    i++;
    j--;
    while (i < arr.GetLength(0))
    {
        if (arr[i, j] == 0)
        {
            arr[i, j] = start;
            start++;
            i++;
        }
        else break;
    }
    i--;
    j--;
    while (j >= 0)
    {
        if (arr[i, j] == 0)
        {
            arr[i, j] = start;
            start++;
            j--;
        }
        else break;
    }
    i--;
    j++;
    while (i >= 0)
    {
        if (arr[i, j] == 0)
        {
            arr[i, j] = start;
            start++;
            i--;
        }
        else break;
    }
    i++;
    if (start <= Math.Pow(arr.GetLength(0), 2)) UlitkaFilling(arr, i, j + 1, start);
    return start;
}
string[,] PrettyUlitka(int dimention)
{
    int[,] numbers = new int[dimention, dimention];
    UlitkaFilling(numbers, 0, 0, 1);
    string[,] ulitka = new string[dimention, dimention];
    for (int i = 0; i < dimention; i++)
    {
        for (int j = 0; j < dimention; j++)
        {
            string fillText = string.Empty;
            if (numbers[i, j] < 10) fillText = "0" + Convert.ToString(numbers[i, j]);
            else fillText = Convert.ToString(numbers[i, j]);
            ulitka[i, j] = fillText;
        }
    }
    return ulitka;
}
void Print2DArray(string[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
            if (j < arr.GetLength(1) - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int length;
Console.WriteLine("выберите длину стороны массива (целое число от 3 до 10)");
while (true)
    try
    {
        length = int.Parse(Console.ReadLine());
        if (length >= 3 && length <= 10) break;
        else Console.WriteLine("от 3 до 10");
    }
    catch
    {
        Console.WriteLine("Целое. Число. От 3 до 10.");
    }
Print2DArray(PrettyUlitka(length));
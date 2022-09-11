/*                  Задача 61 
Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника

    1
   1 1
  1 2 1
 1 3 3 1
1 4 6 4 1               */

Console.WriteLine("введите целое число N (больше 0)");// после 5 строки всё начнёт съезжать. И 
int N;
while (true)
    try
    {
        N = int.Parse(Console.ReadLine());
        if (N > 1) break;
        Console.WriteLine("попробуй ещё раз");
    }
    catch (System.Exception)
    {
        Console.WriteLine("введи целое число больше 1");
    }

int[,] PascalTriangle(int rowsNumber)
{
    int[,] array = new int[rowsNumber, rowsNumber];
    for (int i = 0; i < rowsNumber; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i) array[i, j] = 1;
            else array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}
void PrintTriangle(int[,] arr)
{
    Console.Clear();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        string length = string.Empty;
        for (int space = 0; space < arr.GetLength(0); space++)
        {
            if (arr[i, space] == 0) break;
            length += Convert.ToString(arr[i, space]);
            if (space < i) length += " ";
            // Console.Write(" ");
        }
        Console.SetCursorPosition((Console.WindowWidth - length.Length)/2, i + 1);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0) break;
            Console.Write(arr[i, j]);
            if (j < arr.GetLength(1) - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

PrintTriangle(PascalTriangle(N));
Console.WriteLine();
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Исходный массив:    Массив результатов:
1 4 7 2             7 4 2 1
5 9 2 3             9 5 3 2
8 4 2 4             8 4 4 2
 */

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
            if (j < arr.GetLength(1) - 1) Console.Write("|");
        }
        Console.WriteLine();
    }
}
void SortRowsToMin(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int k = 1;
        while (k < arr.GetLength(1))
        {
            for (int j = 0; j < arr.GetLength(1)-k; j++)
            {
                if (arr [i, j] < arr [i, j+1])
                {
                    int temp = arr [i,j+1];
                    arr[i, j+1] = arr [i, j];
                    arr[i,j] = temp;
                }
            }
            k ++;
        }
    }
}

int [,] array = new int [new Random().Next(3, 8), new Random().Next(7, 10)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortRowsToMin(array);
PrintArray(array);
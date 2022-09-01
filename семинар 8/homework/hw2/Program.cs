/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

5 2 6 7*/

void FillArray( int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
     arr [i, j] = new Random().Next (0, 15);
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
        if (j < arr.GetLength(1) - 1)  Console.Write("|");
     }
     Console.WriteLine();
  }
}
void PrintMinSumRow(int [,] arr)
{
    int rowIndex = 0;
    int min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr [i,j];
        }
        Console.WriteLine($"сумма элементов {i+1} строки равна {sum}");
        if (i == 0 || sum < min) 
        {min = sum;
        rowIndex = i;}
    }
    Console.WriteLine($"сумма элементов {rowIndex+1} строки минимальная");
    for (int j = 0; j < arr.GetLength(1); j++)
     {
        Console.Write(arr[rowIndex, j]);
        if (j < arr.GetLength(1) - 1)  Console.Write("|");
     }
     Console.WriteLine();
}

int height = new Random().Next(1, 4);
int length;
while (true)
{
    length = new Random().Next(3, 5);
    if (length != height) break;
}
int [,] array = new int [height, length];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintMinSumRow(array);
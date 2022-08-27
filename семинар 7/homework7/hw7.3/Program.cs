/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

void FillArray( int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
     arr [i, j] = new Random().Next (1,10);
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
double [] AverageArray (int [,] arr)
{
   double [] arr1 = new double [arr.GetLength(1)];
   for (int i = 0; i < arr.GetLength(1); i++)
   {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
        arr1 [i] +=arr[j,i];
        }
        arr1 [i] /= arr.GetLength(0);
   }
   return arr1;
}
void PrintAverage (double [] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      Console.Write(Math.Round((arr [i]), 2));
      if (i < arr.GetLength(0) - 1)  Console.Write("|");
    }
}

int [,] array = new int [new Random().Next(1, 6), new Random().Next(4, 10)];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintAverage(AverageArray(array));
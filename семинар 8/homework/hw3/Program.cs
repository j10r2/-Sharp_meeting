/*Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:       Результирующая матрица будет:
2 4 | 3 4                       18 20
3 2 | 3 3                       15 18 */

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

int m;
int n;
int k;
while (true)
try
{
    Console.WriteLine("задайте кол-во строк первой матрицы (от 1 до 5)");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("задайте количество столбцов первой матрицы (от 3 до 6)");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("задайте количество столбцов второй матрицы (от 3 до 6    )");
    k = int.Parse(Console.ReadLine());
    break;
}
catch (System.Exception)
{
    Console.WriteLine("ещё разок");
}

int [,] matrix1 = new int [m, n];
int [,] matrix2 = new int [n, k];
FillArray(matrix1);
FillArray(matrix2);

int [,] MatrixMultiply (int [,] arr1, int [,] arr2)
{
    int [,] arrProd = new int [arr1.GetLength(0), arr2.GetLength(1)];
    int mid = arr1.GetLength(1);
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < mid; k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            arrProd [i, j] = sum;
        }
    }
    return arrProd;
}

PrintArray(matrix1);
Console.WriteLine("   x");
PrintArray(matrix2);
Console.WriteLine("   =");
PrintArray(MatrixMultiply(matrix1, matrix2));
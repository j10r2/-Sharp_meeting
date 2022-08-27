/*Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

void FillArray( int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
     arr [i, j] = new Random().Next ( 1,10)/* + Math.Round((new Random().NextDouble()), 2)*/;
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
        if (j < arr.GetLength(1) - 1)  Console.Write(" | ");
     }
     Console.WriteLine();
  }
}
string [,] FillExample(int [,] arr)
{
   string [,] arr1 = new string [arr.GetLength(0), arr.GetLength(1)];
   for (int i = 0; i < arr.GetLength(0); i++)
   {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
     arr1 [i, j] = "-";
     }
   }
   return arr1;
}
void PrintExample(string[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
        Console.Write(arr[i, j]);
        if (j < arr.GetLength(1) - 1)  Console.Write(" | ");
     }
     Console.WriteLine();
  }
}

int [,] random = new  int [new Random().Next(1, 6), new Random().Next(4, 11)];
FillArray(random);
Console.WriteLine("Давай сыграем в рулетку");
try // ну не могу я без обработки исключений :-(
{Console.Write("введи номер строки: ");
int m = int.Parse(Console.ReadLine());
Console.Write("введи номер столбца: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
if (m < 0 || m > random.GetLength(0) || n < 0 || n > random.GetLength(1)) //ввод тоже обработаем
{
    PrintArray(random);
    Console.WriteLine();
    Console.WriteLine($"В данном массиве нет элемента с таким индексом");
}
else
{
    string [,] example = FillExample(random); //сделаем ещё массив с указанием выбранного элемента
    example [m - 1, n - 1] = "*";
    PrintExample(example);
    Console.WriteLine();
    PrintArray(random);
    Console.WriteLine();
    Console.WriteLine($"элемент в {m} строке {n} столбца равен {random [m-1, n-1]}");
    Console.WriteLine();
}
}
catch
{
    Console.WriteLine("Будем считать, что это была русская рулетка и ты застрелился (x_x)");
}
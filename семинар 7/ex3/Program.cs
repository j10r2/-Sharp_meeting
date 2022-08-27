//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали



void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr [i, j] = new Random().Next (1,10);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {Console.Write($"{arr[i, j]} ");}
        Console.WriteLine();
    }
}

int[,] array = new int[3, 4];

FillArray(array);
Console.WriteLine();

int length;
if (array.GetLength(0) > array.GetLength(1)) length = array.GetLength(1);
else length = array.GetLength(0);
int sum = 0;
for (int i = 0; i < length; i++)
{
    sum = sum + array[i,i];
}

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"сумма элементов главной диагонали равна {sum}");
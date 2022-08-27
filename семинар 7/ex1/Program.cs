void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr [i, j] = new Random().Next (-100,100);
        Console.WriteLine();
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

Console.WriteLine("введите высоту массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите длину массива");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = i + j;
}

PrintArray(array);
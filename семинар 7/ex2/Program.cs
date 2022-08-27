void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr [i, j] = new Random().Next (1,10);
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

// Console.WriteLine("введите высоту массива");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("введите длину массива");
// int n = int.Parse(Console.ReadLine());

int[,] array = new int[3, 4];

FillArray(array);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i+=2)
{
    for (int j = 0; j < array.GetLength(1); j+=2)
        array [i,j] *= array [i,j];
}

PrintArray(array);
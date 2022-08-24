void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100, 120);
    }
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = new int[9];
FillArray(array);

Console.WriteLine();
Console.WriteLine("исходный массив:");
PrintArray(array);
Console.WriteLine();


int[] SumArray(int[] arr)
{
    int length1;
    if (arr.Length % 2 == 0)
    {
        length1 = arr.Length / 2;
    }
    else
    {
        length1 = arr.Length / 2 + 1;
    }
    int[] arr1 = new int[length1];
    int length = arr.Length;
    for (int i = 0; i < length1; i++)
    {
        if (i == length - (i + 1))
        {
            arr1[i] = arr[i];
        }
        else
        {
            arr1[i] = arr[i] * arr[length - (i + 1)];
        }
    }
    return arr1;
}

int [] arr1 = SumArray(array);
PrintArray(arr1);

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

int[] array = new int[8];
FillArray(array);

Console.WriteLine();
Console.WriteLine("исходный массив:");
PrintArray(array);
Console.WriteLine();

int length1;
    if (array.Length % 2 == 0)
    {
        length1 = array.Length / 2;
    }
    else
    {
        length1 = array.Length / 2 + 1;
    }
int [] array1 = new int [length1];

void SumArray(int[] arr, int [] arr1)
{
    int length = arr.Length;
    int length1 = arr1.Length;
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
}

Console.WriteLine();
SumArray(array, array1);
Console.WriteLine("массив результатов:");
PrintArray(array1);
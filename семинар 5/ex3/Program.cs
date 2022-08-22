void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (-100,100);
    }
}
void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}

int [] array = new int [123];
FillArray(array);
PrintArray(array);


int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] <= 99 & array[i] >= 10)
    {
        count ++;
    }
}
Console.WriteLine();
Console.WriteLine(count);
void PrintArr (int [] array )
{
    int length = array.Length;
    for (int count = 0; count < length; count++)
    {
        Console.Write(array[count]);
    if (count < 7)
    {
        Console.Write(", ");
    }
    }
}

int [] arr = new int [8];
for (int i = 0; i < 8; i++)
{
    arr [i] = new Random().Next(0, 2);
}

PrintArr(arr);
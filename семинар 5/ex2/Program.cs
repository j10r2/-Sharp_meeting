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

int [] array = new int [8];
FillArray(array);
PrintArray(array);

Console.WriteLine("введите число");
int a = int.Parse(Console.ReadLine());

int var = 0;
for (int i = 0; i < array.Length; i++)
{
    if (a == array[i])
    {
        Console.WriteLine($"заданное число присутствует в массиве");
        var ++;
        break;
    }
}

if ( var== 0)
{
Console.WriteLine($"заданное число в массиве отсутствует");
}
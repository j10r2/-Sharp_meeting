void PrintArr(string [] array)
{
    int length = array.Length;
    for (int count = 0; count < length; count++)
    {
        Console.Write(array[count]);
        if (count < length - 1)
        {
            Console.Write(", ");
        }
    }
}

string [] arr = new string [8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"введите {i + 1}-й элемент массива");
    arr[i] = Console.ReadLine();
}

    Console.WriteLine();
    Console.WriteLine($"а теперь распечатаем (зря вводили что ли?)");

PrintArr(arr);
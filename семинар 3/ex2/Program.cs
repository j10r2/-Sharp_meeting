Console.WriteLine("введите целое число:");
int a = int.Parse(Console.ReadLine());
int index = 1;
while (index <= Math.Abs(a))
{
    Console.Write(index * index);
    if (index < Math.Abs(a))
    {
        Console.Write(", ");
    }
    index++;
}

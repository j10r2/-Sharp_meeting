// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// копируем метод, написанный на семинаре
void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

Console.WriteLine("юзер, тебе выпала честь выбрать длину массива"); //юзер сможет
int count = 0;
int length;
while (true)
{
    try
    {
        length = int.Parse(Console.ReadLine());
        Console.Write($"красава, с {count + 1} попытки");
        if (count == 0)
        {
            Console.WriteLine(" (звуки фанфар)");
        }
        Console.WriteLine();
        break;
    }
    catch (System.Exception)
    {
        switch (count)
        {
            case 0:
            Console.WriteLine("вообще от тебя ждали ЦЕЛОЕ ПОЛОЖИТЕЛЬНОЕ ЧИСЛО");
            break;
            case < 3:
            Console.WriteLine("попробуй ещё раз");
            break;
            case < 4:
            Console.WriteLine("ну давай же, не тупи");
            break;
            default:
            Console.WriteLine("терпение машины бесконечно...");
            break;
        }
        count++;
    }
}

int [] arro = new int [length];
FillArray(arro);

int n = 0;
for (int i = 0; i < length; i++)
{
    if (arro[i] % 2 == 0)
    {
        n ++;
    }
}

Console.WriteLine($"в вашем массиве {n} чётых чисел");
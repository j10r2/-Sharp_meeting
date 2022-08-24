/*Задача 36:
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. */

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


Console.WriteLine("юзер, тебе выпала честь выбрать длину массива"); //не подведи. Хотя о чём я...
int count = 0;
int length;
while (true)
{
    try // ввод с проверкой пользователя на жадность (-_-)
    {
        length = int.Parse(Console.ReadLine());
        if (length > 20)    
        {
            length = 20;
            Console.WriteLine("Жадное... 20 тебе хватит.");
        }
        else
        {Console.WriteLine($"красава, с {count + 1} попытки");}
        Console.WriteLine();
        break;
    }
    catch (System.Exception) //обработка исключений для не очень талантливых пользователей
    {
        switch (count)
        {
            case 0:
            Console.WriteLine("ЦЕЛОЕ ПОЛОЖИТЕЛЬНОЕ ЧИСЛО");
            break;
            case 1:
            Console.WriteLine("попробуй ещё раз");
            break;
            case < 4:
            Console.WriteLine("(-_-)");
            break;
            default:
            Console.WriteLine("(x_x)");
            break;
        }
        count++;
    }
}

int [] array = new int [length];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int sum = 0;
for (int i = 0; i < length; i++)
{
    if (i % 2 > 0)
    {
        sum += array[i];
    }
}

Console.WriteLine($"сумма элементов с нечётными индексами равна {sum}");
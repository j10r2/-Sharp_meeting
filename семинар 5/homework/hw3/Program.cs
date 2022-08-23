// Задача 38:
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

void FillArray(double[] arr) //наш любимый метод заполнения массива
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100, 120) + Math.Round((new Random().NextDouble()), 3); //округлим до 3 знаков после запятой
    }
}
void PrintArray(double[] arr)//и для вывода на экран
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1 & i > 0)
        { Console.Write("; ");} //т.к. в числах будут запятые, между элементами будем ставить ";"
        Console.Write(arr[i]);
    }
}

double[] array = new double[10]; // создадим массив, большой нам не нужен, мы же не жадные
FillArray(array);

double min = array [0];
double max = min;

for (int i = 0; i < 10; i++)
{
    if (array [i] < min)
    {
        min = array [i];
    }
    else
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
}

if (min == max)
{
    Console.WriteLine("товарищ, у нас социалистический массив, в нём все равны...");
}
else
{
    Console.WriteLine($"разница между максимальным и минимальным элементами массива равна {max - min}");
}
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void FillAuxiliaryArray(int[] arr) //создаём вспомогательный массив, из которого будет заполняться наш трёхмерный
{
    int length = arr.Length;
    arr[0] = 10;
    for (int i = 1; i < length; i++)
    {
        arr[i] = arr[i - 1] + 1;
    }
}
int[,,] Fill3DArray(int[] arr)
{
    int height, length, depth;
    while (true) //пользователь сам задаёт размерность массива
        try
        {
            Console.WriteLine("введите высоту массива");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine($"введите длину массива (не больше {arr.GetLength(0) / 2 / height})");
            length = int.Parse(Console.ReadLine());
            if (height * length > arr.GetLength(0) / 2)
            {
                Console.WriteLine("не осталось места для третьего измерения, сделай поменьше");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"введите глубину массива (не больше {arr.GetLength(0) / height / length})");
                depth = int.Parse(Console.ReadLine());
                if (height * length * depth <= 90) break;
                else Console.WriteLine("многовато, попробуй поменьше");
                Console.WriteLine();
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("вводи целые числа");
            Console.WriteLine();
        }
    int[,,] newArr = new int[height, length, depth];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int index;
                while (true)
                {
                    index = new Random().Next(0, arr.GetLength(0));
                    if (arr[index] != 0) break;
                }
                newArr[i, j, k] = arr[index];
                arr[index] = 0;
            }
        }
    }
    return newArr;
}
void Print3DArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})");
                if (j < arr.GetLength(1) - 1) Console.Write(" | ");
            }
            Console.WriteLine();
        }
    }
}
int[] auxiliary = new int[90];
FillAuxiliaryArray(auxiliary);
Print3DArray(Fill3DArray(auxiliary));
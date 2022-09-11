/* Задача 57 Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6


1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

void Fill2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-5, 15);
        }
    }
}
void PrintDictionaryArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if ((arr[0, j] != 0) && (arr[1, j] != 0)) Console.WriteLine($"{arr[0, j]} встречается в массиве {arr[1, j]} раз(-а)");
    }
}
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
            if (j < arr.GetLength(1) - 1) Console.Write("|");
        }
        Console.WriteLine();
    }
}
int[,] FrequencyDictionary(int[,] arr)
{
    int[,] frequencyDictionary = new int[2, (arr.GetLength(0) * arr.GetLength(1))];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int finder = 0; finder < (arr.GetLength(0) * arr.GetLength(1)); finder++)
            {
                if (frequencyDictionary[0, finder] == arr[i, j])
                {
                    frequencyDictionary[1, finder]++;
                    break;
                }
                else if ((frequencyDictionary[0, finder] == 0) && (frequencyDictionary[1, finder] == 0))
                {
                    frequencyDictionary[0, finder] = arr[i, j];
                    frequencyDictionary[1, finder]++;
                    break;
                }
            }
        }
    }
    return frequencyDictionary;
}
void SortRowsToMax(int[,] arr)
{
    int k = 1;
    while (k < arr.GetLength(1))
    {
        for (int j = 0; j < arr.GetLength(1) - k; j++)
        {
            if (arr[0, j] > arr[0, j + 1])
            {
                int temp0 = arr[0, j + 1];
                arr[0, j + 1] = arr[0, j];
                arr[0, j] = temp0;
                int temp1 = arr[1, j + 1];
                arr[1, j + 1] = arr[1, j];
                arr[1, j] = temp1;
            }
        }
        k++;
    }
}

int[,] array = new int[3, 4];
Fill2DArray(array);
Print2DArray(array);
Console.WriteLine();

int[,] dictionary = FrequencyDictionary(array);

SortRowsToMax(dictionary);
PrintDictionaryArray(dictionary);
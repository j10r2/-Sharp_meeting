Console.WriteLine("введите число ");
int n = Convert.ToInt32(Console.ReadLine());
string m = Convert.ToString(n);
int length =  m.Length;
int [] array = new int[length];
int i = 0;

while (i < length)
{
    /*array [i] = Convert.ToInt32(m[i]); - тут была ошибка. При извлечении из строки элемента по индексу он преобразуется в формат char, и для перевода его в число его надо сначала снова в string конвертировать */
    array [i] = Convert.ToInt32(m.Substring(i, 1));
    i++;
}




for(int k=0; k < length; k++)
{
Console.WriteLine(array[k]);
}
int sum = 0;
for (int j = 0; j < length; j++)
{
    sum += array[j];
}
Console.WriteLine(sum);
// Console.WriteLine("введите целое число больше 0");
// int a = int.Parse(Console.ReadLine());
// int length = 0;
// if (a / 10 == 0)
// {
//     Console.WriteLine("в числе одна цифра");
// }
// else
// {
//     while (a > 0)
// {
//     a = a / 10;
//     length ++;
//     Console.WriteLine(length);
// }
// Console.WriteLine($"число состоит из { length } знаков");
// }

Console.WriteLine("введите целое число больше 0");
int n = int.Parse(Console.ReadLine());
int prod = 1;
for (int i = 2; i <= n; i++)
{
    prod = prod * i;
}
Console.WriteLine(prod);
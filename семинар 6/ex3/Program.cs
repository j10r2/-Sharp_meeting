// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число N");
int N = int.Parse(Console.ReadLine());
int firstDigit = 0;
int secondDigit = 1;
Console.Write("0 1 ");
if (N > 2)
{
    
int c;
for (int i = 2; i < N; i ++)
{
    c = firstDigit + secondDigit;
    Console.Write(c + " ");
    firstDigit = secondDigit;
    secondDigit = c;
}
}

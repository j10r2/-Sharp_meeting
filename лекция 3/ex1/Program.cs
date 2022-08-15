void Method1()
{
    Console.WriteLine("Онтоша");
}
// Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст ололо");

void Method21(string msg, int count)
{
    for (int i = 1; i <= count; i++)
        Console.WriteLine(msg);
}
// Method21("Текст ололо", 4);

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);

string Method4(int count, string c)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
// string res = Method4(10, "fuck");
// Console.WriteLine(res);

// for (int i = 2; i < 10; i++)
// {
//     for (int count = 0; count <= 10; count++)
//     {
//         Console.Write($"{i}*{count}={i * count}; ");
//     }
//     Console.WriteLine();
// }

string text = "fuck you bitch";
string Method5(string txt, char ol, char ne)
{
    string txt1 = string.Empty;
    int length = txt.Length;
    for (int i = 0; i < length; i++)
    {
        if(txt[i] == ol) txt1 = txt1 + $"{ne}";
        else txt1 = txt1 + $"{txt[i]}";
    }
    return txt1;
}
string newtext = Method5(text, 'c', 'o');
Console.WriteLine(newtext);
string low = Method5(newtext, 'k', 'S');
Console.WriteLine(low);
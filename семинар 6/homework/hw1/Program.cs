// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("сколько чисел будем вводить?");
int count = 0;
int M;
while (true)
{
    try // проверка ввода
    {
        M = int.Parse(Console.ReadLine());
        if (M > 7)
        {
            M = 7;
            Console.WriteLine("Плохо быть жадным. вводи 7 чисел");
        }
        break;
    }
    catch (System.Exception) //обработка исключений
    {
        switch (count)
        {
            case 0:
                Console.WriteLine("ЦЕЛОЕ ПОЛОЖИТЕЛЬНОЕ ЧИСЛО");
                break;
            default:
                Console.WriteLine("(x_x)");
                break;
        }
        count++;
    }
}

// int RecursiveCount(int s, int col = 0) 
// {
//     if (int.Parse(Console.ReadLine()) > 0) col++;
//     Console.WriteLine(col);
//     s = s - 1;
//     if (s == 0) return col;
//         RecursiveCount(s);
//         return 0;
// }
/*неудачная попытка решить через рекурсию. 
Зато выяснил, что рекурсия не передаёт значение переменной между уровнями*/

if (M <= 0)
{
    Console.WriteLine("Не хочешь - как хочешь");
}
else
{
    Console.WriteLine("вводи по порядку:");
    int col = 0;
    for (int i = 0; i < M; i++) { if (Convert.ToDouble(Console.ReadLine()) > 0) col++; }
    //можно было бы проверить ввод, но допустим, что пользователь попался адекватный
    Console.WriteLine($"{col} из введённых чисел больше 0");
}

//а без обработки исключений было бы 6 строчек кода...
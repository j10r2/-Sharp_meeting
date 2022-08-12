Console.WriteLine("Введите номер четверти (от 1 до 4):");
int count = 0;
while (count < 5){
try
    {
    int x = Int32.Parse(Console.ReadLine());

    string [] q1 = {"x > 0 и y > 0", "x < 0 и y > 0", "x < 0 и y < 0", "x > 0 и y < 0"};
    Console.WriteLine("диапазон значений для четверти " + x + " равен: " + q1 [x-1]);
    break;
    }
catch
    {
        Console.WriteLine("От 1 до 4, пожалуйста");
        Console.WriteLine();
        count ++;
        if (count == 5)
            {
                Console.WriteLine("Ты исчерпал свои попытки");
            }
    }
}
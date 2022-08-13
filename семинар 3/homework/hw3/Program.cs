Console.WriteLine("попробуй ввести любое целое число с трёх попыток (лучше небольшое):");
int count = 0;
while (count < 3)
    try
    {
        int a = int.Parse(Console.ReadLine());
        int index = 1;
        while ((index < a) || (index > a))
        {
            Console.Write(Math.Pow(index, 3));
            if ((index < a) || (index > a))
            {
                Console.Write(", ");
            }
            if (a < 0)
            {
                index--;
            }
            else
            {
                index++;
            }
            if (index == a)
            {
                Console.Write(Math.Pow(index, 3));
            }
        }
        break;
    }
    catch (System.Exception)
    {
        if (count < 2)
        {
            Console.WriteLine("Не получилось, давай ещё раз");
        }
        else
        {
            Console.WriteLine("А я так в тебя верил...");
        }
        count ++;
    }


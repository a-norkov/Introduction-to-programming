// Seminar 3
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Найти кубы чисел от 1 до n.\n" 
+ " 2 - Посчитать сумму цифр в числе.\n"
+ " 3 - Написать программу вычисления произведения чисел от 1 до N.\n"
+ " 4 - Показать кубы чисел, заканчивающихся на четную цифру.\n\n"
+ "Введите число соответствующее одному из вариантов выше:");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        string namee = "les3_task1"
        ();
        break;
    case 2:
        les3_task2();
        break;
    case 3:
        les3_task3();
        break;
    case 4:
        les3_task4();
        break;    
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}


// найти кубы чисел от 1 до n
void les3_task1()
{
    Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine());

    if (a > 0)
    {
        Console.WriteLine($"\n{"число", 15}  {"куб числа", 15}");
        for (int i = 1; i <= Math.Abs(a); i ++)
        {
            Console.WriteLine($"{i, 15}  {i * i * i, 15}");   
        }
    }
    else
    {
        Console.WriteLine("\nВведенное число меньше либо равно нулю");
    }
}

// посчитать сумму цифр в числе
void les3_task2()
{
    Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine());
    int sum = 0;


    while (a != 0)
    {
        sum += a % 10;
        a /= 10;  
    }

    Console.WriteLine($"\nСумма цифр в числе: {sum}");
}

// Написать программу вычисления произведения чисел от 1 до N
void les3_task3()
{
    Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine());
    long result = 1;

    if (a > 0)
    {
        while (a != 0)
        {
            result = result * a;
            a--;
        }
        Console.WriteLine($"\nПроизведение чисел от 1 до N: {result}");
    }
    else
    {
        Console.WriteLine("Введенное число меньше либо равно нулю");
    }
}

// Показать кубы чисел, заканчивающихся на четную цифру
void les3_task4()
{
    Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine());

    if (a > 0)
    {
        Console.WriteLine($"\n{"число", 15}  {"куб числа", 15}");
        for (int i = 1; i <= Math.Abs(a); i ++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i, 15}  {i * i * i, 15}");
            }
                
        }
    }
    else
    {
        Console.WriteLine("\nВведенное число меньше либо равно нулю");
    }
}

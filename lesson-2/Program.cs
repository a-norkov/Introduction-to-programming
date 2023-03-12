// Seminar 2
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Дано число обозначающее день недели. Выяснить является номер дня недели выходным.\n" 
+ " 2 - По двум заданным числам проверять является ли одно квадратом другого.\n"
+ " 3 - Задать номер четверти, показать диапазоны для возможных координат.\n"
+ " 4 - Выяснить является ли число чётным.\n");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les2_task1();
        break;
    case 2:
        les2_task2();
        break;
    case 3:
        les2_task3();
        break;
    case 4:
        les2_task4();
        break;
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
void les2_task1()
{

    Console.WriteLine("Введите число");
    int number = int.Parse(Console.ReadLine());


    if (number <= 7 && number >= 1)
    {
        if (number == 6 || number == 7) Console.WriteLine("День недели является выходным");
        else Console.WriteLine("День недели не является выходным");
    }
    else 
    {
        Console.WriteLine("Введенное число не соответсвует дням недели (меньше 1 или больше 7)");
    }

}

// По двум заданным числам проверять является ли одно квадратом другого.
void les2_task2()
{

    Console.WriteLine("Введите первое число:");
    int number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int number2 = int.Parse(Console.ReadLine());

    int square1 = number1 * number1;
    int square2 = number2 * number2;

    if (number1 == square2) 
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else if (number2 == square1) 
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
    else 
    {
        Console.WriteLine("Первое число не является квадратом второго также второе число не является квадратом первого");
    }

}

// Задать номер четверти, показать диапазоны для возможных координат.
void les2_task3()
{

    Console.WriteLine("Введите номер четверти (1 - 4)");
    int numberLes3 = int.Parse(Console.ReadLine());

    if (numberLes3 >= 1 && numberLes3 <= 4)
    {
        if (numberLes3 == 1)
        {
            Console.WriteLine("Возможный диапазон для \n"  
            + " координаты X: от нуля до плюс бесконечности\n"
            + " координаты Y: от нуля до плюс бесконечности");
        }
        else if (numberLes3 == 2)
        {
            Console.WriteLine("Возможный диапазон для \n"  
            + " координаты X: от нуля до минус бесконечности\n"
            + " координаты Y: от нуля до плюс бесконечности");
        }
        else if (numberLes3 == 3)
        {
            Console.WriteLine("Возможный диапазон для \n"  
            + " координаты X: от нуля до минус бесконечности\n"
            + " координаты Y: от нуля до минуч бесконечности");
        }
        else
        {
            Console.WriteLine("Возможный диапазон для \n"  
            + " координаты X: от нуля до плюс бесконечности\n"
            + " координаты Y: от нуля до минус бесконечности");
        }
    }
    else
    {
        Console.WriteLine("Введенное число не соответсвует четвертям координат (меньше 1 или больше 4)");
    }

}

// Найти расстояние между точками в пространстве 2D/3D.
void les2_task4()
{
    
    Console.WriteLine("Введите число соответствующее одному из вариантов ниже:\n" 
    + " 1 - Рассчитать расстояние между точками в 2D пространстве\n" 
    + " 2 - Рассчитать расстояние между точками в 3D пространстве");
    int numberLes4 = int.Parse(Console.ReadLine());

    if (numberLes4 == 1)
    {
        Console.WriteLine("Введите координаты (X, Y) первой точки, через запятую, пример - (12, 32)");
        // создаем переменную массива строк и в нее добавляем массив строк разделенных запятой
        string[] a = Console.ReadLine().Split(',');
        Console.WriteLine("Введите координаты (X, Y) второй точки, через запятую, пример - (12, 32)");
        // создаем переменную массива строк и в нее добавляем массив строк разделенных запятой
        string[] b = Console.ReadLine().Split(',');

        if (a.Length == 2 && b.Length == 2)
        {
            double ax = double.Parse(a[0].Trim());
            double ay = double.Parse(a[1].Trim());
            double bx = double.Parse(b[0].Trim());
            double by = double.Parse(b[1].Trim());
            double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
            Console.WriteLine("Расстояния между точками в 2D пространстве равно: " + result);
        }

    }
    else if (numberLes4 == 2)
    {
        Console.WriteLine("Введите координаты (X, Y, Z) первой точки, через запятую, пример - (12, 32, 21)");
        // создаем переменную массива строк и в нее добавляем массив строк разделенных запятой
        string[] a = Console.ReadLine().Split(',');
        Console.WriteLine("Введите координаты (X, Y, Z) второй точки, через запятую, пример - (12, 32, 21)");
        // создаем переменную массива строк и в нее добавляем массив строк разделенных запятой
        string[] b = Console.ReadLine().Split(',');

        if (a.Length == 3 && b.Length == 3)
        {
            double ax = double.Parse(a[0].Trim()); // методом Trim - убираем пробелы.
            double ay = double.Parse(a[1].Trim());
            double az = double.Parse(a[2].Trim());
            double bx = double.Parse(b[0].Trim());
            double by = double.Parse(b[1].Trim());
            double bz = double.Parse(b[2].Trim());
            double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
            Console.WriteLine("Расстояния между точками в 3D пространстве равно: " + result);
        }
    }
    else
    {
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
    }

}
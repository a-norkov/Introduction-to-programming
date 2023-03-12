// Seminar 9
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Показать натуральные числа от M до N, N и M заданы.\n" 
+ " 2 - Найти сумму элементов от M до N, N и M заданы.\n"
+ " 3 - Найти сумму цифр числа.\n"
+ " 4 - Написать программу вычисления функции Аккермана.\n"
+ " 5 - Написать программу возведения числа А в целую стень B.\n"
+ " 6 - Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем.\n");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les9_task1();
        break;
    case 2:
        les9_task2();
        break;
    case 3:
        les9_task3();
        break;
    case 4:
        les9_task4();
        break;
    case 5:
        les9_task5();
        break;
    case 6:
        les9_task6();
        break;
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

//Показать натуральные числа от M до N, N и M заданы.
void les9_task1()
{
    Console.WriteLine("Введите число M:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число N:");
    int n = int.Parse(Console.ReadLine()) + 1;


    Console.WriteLine($"Натуральные числа от {m} до {n}:");
    showNumbers(m, n);

    void showNumbers (int a, int b)
    {
        if (a == b)
        {
            return;
        }

        else 
        {
            showNumbers(a, (b - 1));
            Console.WriteLine (b - 1);
        }

    }

}

//Найти сумму элементов от M до N, N и M заданы.
void les9_task2()
{
    Console.WriteLine("Введите число M:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число N:");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Сумма элементов от {m} до {n} : {numberSumElement(m, n)}");

    int numberSumElement (int a, int b)
    {
        if (a < b)
        {
            return b + numberSumElement(a, b - 1);
        }

        else if (a > b)
        {
            return b + numberSumElement(a, b + 1);
        }

        else 
        {
            return a;
        }

    }
}

//Найти сумму цифр числа.
void les9_task3()
{
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    int sum = new int();

    Console.WriteLine($"Сумма чисел равна: {numberSum(number)}");

    int numberSum (int number)
    {
        if (number == 0)
        {
            return 0;
        }
        else
        {
            return numberSum(number/10) + number%10;
        }
    }


}

//Написать программу вычисления функции Аккермана.
void les9_task4()
{

}

//Написать программу возведения числа А в целую стень B.
void les9_task5()
{
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите степень числа:");
    int pow = int.Parse(Console.ReadLine());

    Console.WriteLine($"Число {number} в степени {pow} : {numberSquare(number, pow)}");

    int numberSquare (int a, int b)
    {
        if (b > 0)
        {
            return a * numberSquare(a, b - 1);
        } 
        else
            return 1;
    }

}

//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем.
void les9_task6()
{

}

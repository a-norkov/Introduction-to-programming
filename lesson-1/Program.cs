// Seminar 1
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - По двум заданным числам проверять является ли первое квадратом второго.\n" 
+ " 2 - По заданному номеру дня недели вывести его название.\n"
+ " 3 - Найти максимальное из трех чисел.\n"
+ " 4 - Выяснить является ли число чётным.\n"
+ " 5 - Показать четные числа от 1 до N.\n"
+ " 6 - Показать последнюю цифру трёхзначного числа.\n"
+ " 7 - Показать вторую цифру трёхзначного числа.\n"
+ " 8 - Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.\n"
+ " 9 - Удалить вторую цифру трёхзначного числа.\n"
+ " 10 - Выяснить, кратно ли число заданному, если нет, вывести остаток.\n"
+ " 11 - Найти третью цифру числа или сообщить, что её нет.\n");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les1_task1();
        break;
    case 2:
        les1_task2();
        break;
    case 3:
        les1_task3();
        break;
    case 4:
        les1_task4();
        break;
    case 5:
        les1_task5();
        break;
    case 6:
        les1_task6();
        break;
    case 7:
        les1_task7();
        break;
    case 8:
        les1_task8();
        break;
    case 9:
        les1_task9();
        break;
    case 10:
        les1_task10();
        break;
    case 11:
        les1_task11();
        break;
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

// По двум заданным числам проверять является ли первое квадратом второго.
void les1_task1()
{

    Console.WriteLine("Введите первое число");
    int numberA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int numberB = int.Parse(Console.ReadLine());

    int square = numberB * numberB;

    if (numberA == square) 
    {
        Console.WriteLine("Первое введенное число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Первое введенное число не является квадратом второго");
        
    }

}

// По заданному номеру дня недели вывести его название.
void les1_task2()
{

    Console.WriteLine("Введите число от 1 до 7");
    int number = int.Parse (Console.ReadLine());

    if (number > 7 || number < 1)
    {
        Console.WriteLine ("Введено число меньше 1 или больше 7");
    }
    else
    {
        if (number == 1) Console.WriteLine ("Понедельник");
        else if (number == 2) Console.WriteLine ("Вторник");
        else if (number == 3) Console.WriteLine ("Среда");
        else if (number == 4) Console.WriteLine ("Четверг");
        else if (number == 5) Console.WriteLine ("Пятница");
        else if (number == 6) Console.WriteLine ("Суббота");
        else if (number == 7) Console.WriteLine ("Воскресенье");

    }

}

// Найти максимальное из трех чисел.
void les1_task3()
{

    Console.WriteLine("Введите первое число:");
    int number1 = int.Parse (Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    int number2 = int.Parse (Console.ReadLine());

    Console.WriteLine("Введите третье число:");
    int number3 = int.Parse (Console.ReadLine());

    int max = number1;

    if (max < number2) max = number2;
    if (max < number3) max = number3;

    Console.WriteLine("Максимальное число из введенных: " + max);

}

// Выяснить является ли число чётным.
void les1_task4()
{

    Console.WriteLine("Введите число:");
    int number = int.Parse (Console.ReadLine());

    int a = number % 2;
    if ((number % 2) == 0) 
    {
        Console.WriteLine("Число является четным");
    }
    else
    {
        Console.WriteLine("Число является нечетным");
    }

}

// Показать четные числа от 1 до N.
void les1_task5()
{

    Console.WriteLine("Введите число:");
    int number = int.Parse (Console.ReadLine());
    int counter = 1;

    if (number > 0)
    {
        Console.WriteLine("Четные числа от 1 до " + number + ":");
        while (counter <= number)
        {
            if((counter % 2) == 0) Console.WriteLine(counter);
            counter ++;
        }
    }
    else
    {
        Console.WriteLine("Четные числа от " + number + " до 1:");
        while (number <= counter)
        {
            if((number % 2) == 0) Console.WriteLine(number);
            number ++;
        }
    }

}

// Показать последнюю цифру трёхзначного числа.
void les1_task6()
{

    Console.WriteLine("Введите трехзначное число:");
    int number = int.Parse (Console.ReadLine());

    if (number < 1000 && number > 99)
    {
        Console.WriteLine("Последняя цифра введенного числа: " + number % 10);
    }
    else
    {
        Console.WriteLine("Введенное число не трехзначное");
    }

}

// Показать вторую цифру трёхзначного числа.
void les1_task7()
{

    Console.WriteLine("Введите трехзначное число:");
    int number = int.Parse (Console.ReadLine());

    if (number < 1000 && number > 99)
    {
        Console.WriteLine("Вторая цифра введенного числа: " + (number % 100) / 10);
    }
    else
    {
        Console.WriteLine("Введенное число не трехзначное");
    }

}

// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
void les1_task8()
{

    Console.WriteLine("Введите число типа [10, 99]:");
    string number = Console.ReadLine();

    int counter = 0;
    int max = 0;

    while (counter < number.Length)
    {
        int temp = number[counter] - '0';
        if (temp >= 0 && temp <= 9)
        {
            if (temp > max) max = temp;
        }
        counter ++;
    }

    Console.WriteLine("Наибольшее из введенных чисел: " + max);

}

// Удалить вторую цифру трёхзначного числа.
void les1_task9()
{

    Console.WriteLine("Введите трехзначное число:");
    string number = Console.ReadLine();
    string temp = "";

    if (number.Length == 3) 
    {
        Console.WriteLine("Полученное число: " + number.Remove(1, 1));
    }

    else
    {
        Console.WriteLine("Введеное число не трехзначное");
    }

}

// Выяснить, кратно ли число заданному, если нет, вывести остаток.
void les1_task10()
{

    Console.WriteLine("Введите первое число для проверки кратно ли оно второму:");
    int number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число, для проверки кратно ли первое число второму:");
    int number2 = int.Parse(Console.ReadLine());

    if (number1 % number2 == 0)
    {
        Console.WriteLine("Первое число кратно второму");
    }

    else
    {
        Console.WriteLine("Первое число не кратно второму, остаток от деления равен: " + number1 % number2);
    }

}

// Найти третью цифру числа или сообщить, что её нет.
void les1_task11()
{

    Console.WriteLine("Введите число состоящее из трех и более знаков:");
    string number = Console.ReadLine();
    string temp = "";

    if (number.Length > 2) 
    {
        Console.WriteLine("Полученное число: " + number[2]);
    }

    else
    {
        Console.WriteLine("Введеное число состоит менее чем из трех знаков");
    }

}
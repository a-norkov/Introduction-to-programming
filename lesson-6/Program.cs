// Seminar 6
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Показать двумерный массив размером m×n заполненный вещественными числами.\n" 
+ " 2 - Задать двумерный массив следующим правилом: Aₘₙ = m+n.\n"
+ " 3 - В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.\n"
+ " 4 - Написать программу, которая обменивает элементы первой строки и последней строки.\n");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les6_task1();
        break;
    case 2:
        les6_task2();
        break;
    case 3:
        les6_task3();
        break;
    case 4:
        les6_task4();
        break;
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

//Показать двумерный массив размером m×n заполненный вещественными числами.
void les6_task1()
{
    Console.WriteLine("Введите m:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = int.Parse(Console.ReadLine()); 
    double [,] numbers = new double [m, n];
    Random rnd = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.NextDouble() + rnd.Next(1, 10);
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
        }

        Console.Write("\n");
    }

}

//Задать двумерный массив следующим правилом: Aₘₙ = m+n.
void les6_task2()
{
    Console.WriteLine("Введите m:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = int.Parse(Console.ReadLine()); 
    int [,] numbers = new int[m, n];
    //Random rnd = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = i + j;
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
        }

        Console.Write("\n");
    }
}

//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.
void les6_task3()
{

    int [,] numbers = new int [10, 10];
    Random rnd = new Random();

    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(1, 10);
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                numbers[i, j] = numbers[i, j] * numbers[i, j];
            }
        }

        Console.Write("\n");
    }

    Console.WriteLine("Обработанный массив:");
        for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
        }

        Console.Write("\n");
    }

}

//Написать программу, которая обменивает элементы первой строки и последней строки.
void les6_task4()
{
    int [,] numbers = new int [10, 10];
    int tmp = new int();
    Random rnd = new Random();

    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(1, 10);
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
        }

        Console.Write("\n");
    }

    Console.WriteLine("Обработанный массив:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        tmp = numbers[0, i];
        numbers[0, i] = numbers[9, i];
        numbers[9, i] = tmp;
    }

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
        }

        Console.Write("\n");
    }
}

// Seminar 7
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.\n" 
+ " 2 - Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.\n"
+ " 3 - В прямоугольной матрице найти строку с наименьшей суммой элементов.\n");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les7_task1();
        break;
    case 2:
        les7_task2();
        break;
    case 3:
        les7_task3();
        break;
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

//Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void les7_task1()
{
    Console.WriteLine("Введите m:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = int.Parse(Console.ReadLine()); 
    int [,] numbers = new int[m, n];
    Random rnd = new Random();
    double avg = new double();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {

            numbers[i, j] = rnd.Next(1, 10);
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
            avg += numbers[i, j];

            if (j == numbers.GetLength(1) - 1)
            {
                Console.Write($" avg = {(avg/n).ToString("0#.#0")}");
                avg = 0;
            }

        }

        Console.Write("\n");
    }

}

//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void les7_task2()
{
    Console.WriteLine("Введите m:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = int.Parse(Console.ReadLine()); 
    int [,] numbers = new int[m, n];
    Random rnd = new Random();
    int tmp = new int();

    // заполнение и вывод массива
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


    //сортировка массива методом пузырька
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int p = 0; p < numbers.GetLength(1) - 1; p++)
            {
                if (numbers[i, p] > numbers[i, p + 1])
                {
                    tmp = numbers[i, p + 1];
                    numbers[i, p + 1] = numbers[i, p];
                    numbers[i, p] = tmp;
                }
            }
        }
    }

    //вывод отсортированного массива
    Console.WriteLine("\nОтсортированный массив:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
        }
        Console.Write("\n");
    }
}


//В прямоугольной матрице найти строку с наименьшей суммой элементов.
void les7_task3()
{

    Console.WriteLine("Введите m:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите n:");
    int n = int.Parse(Console.ReadLine()); 
    int [,] numbers = new int[m, n + 1];
    Random rnd = new Random();
    int sum = new int();
    int [] min = new int[2];

    // заполнение и вывод массива
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (j < numbers.GetLength(1) - 1)
            {
                numbers[i, j] = rnd.Next(1, 10);
                Console.Write($"{numbers[i, j].ToString("0#.#0")} | ");
                sum += numbers[i, j];
            }

            if (j == numbers.GetLength(1) - 1)
            {
                Console.Write($" sum = {sum.ToString("0#.#0")}");
                numbers[i, j] = sum;
                sum = 0;
            }
        }

        Console.Write("\n");
    }

    //нахождение строки с минимальной суммой
    min[0] = numbers[0, n];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        if (min[0] > numbers[i, n])
        {
            min[0] = numbers[i, n];
            min[1] = i;
        }
    }

    //вывод строки с наименьшей суммой элементов
    Console.WriteLine("\nСтрока с наименьшей суммой элементов:");

    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        Console.Write($"{numbers[min[1], j].ToString("0#.#0")} | ");
    }

    Console.Write($" sum = {min[0].ToString("0#.#0")}");


}

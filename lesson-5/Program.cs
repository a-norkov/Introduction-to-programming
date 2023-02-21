// Seminar 5
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.\n" 
+ " 2 - Написать программу масштабирования фигуры.\n"
+ " 3 - Написать программу копирования массива.\n");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les5_task1();
        break;
    case 2:
        les5_task2();
        break;
    case 3:
        les5_task3();
        break;
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.
// x = (b2-b1)/(k1-k1)
// y = k1 * x + b1
void les5_task1()
{
    Console.WriteLine("Введеное b1:");
    double b1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введеное k1:");
    double k1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введеное b2:");
    double b2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введеное k2:");
    double k2 = double.Parse(Console.ReadLine());

    double x;
    double y;

    x = (b2-b1)/(k1-k2);
    y = k1 * x + b1;

    Console.WriteLine($"Координаты точки пересечия: X = {x}, Y = {y}");
}

// Написать программу масштабирования фигуры
void les5_task2()
{
    //Создание объекта для генерации чисел
    Random rnd = new Random();
    int [] array = new int[100];
    int evenNumQty = 0;
    int notEvenNumQty = 0;

    //заполнение массива случайными трехзначными числами и подсчет четных и нечетных значений
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
        if (array[i] % 2 == 0) evenNumQty ++;
        else notEvenNumQty ++;
    }

    Console.WriteLine($"Количество четных чисел: {evenNumQty}");
    Console.WriteLine($"Количество нечетных чисел: {notEvenNumQty}");
}

// Написать программу копирования массива.
void les5_task3()
{
    //Создание объекта для генерации чисел
    Random rnd = new Random();
    int [] array = new int[123];

    Console.WriteLine("Введите числа через запятую, пример - (12, 32)");
    // создаем переменную массива строк и в нее добавляем массив строк разделенных запятой
    string[] temp = Console.ReadLine().Split(',');
    int a = int.Parse(temp[0]);
    int b = int.Parse(temp[1]);
    int aCounter = 0;
    int bCounter = 0;

    //заполнение массива случайными трехзначными числами и суммирование значений стоящих на нечетной позиции
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }

    //проверяем сколько раз встречается число первое введенное число и второе
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a) aCounter ++;
        if (array[i] == b) bCounter ++;
    }

    Console.WriteLine($"Число {a} встречается в массиве: {aCounter} раз");
    Console.WriteLine($"Число {b} встречается в массиве: {bCounter} раз");

}

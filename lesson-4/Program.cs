// Seminar 4
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.\n" 
+ " 2 - Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел.\n"
+ " 3 - В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].\n"
+ " 4 - Найти сумму чисел одномерного массива стоящих на нечетной позиции.\n"
+ " 5 - Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.\n"
+ " 6 - В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.\n\n"
+ "Введите число соответствующее одному из вариантов выше:");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les4_task1();
        break;
    case 2:
        les4_task2();
        break;
    case 3:
        les4_task3();
        break;
    case 4:
        les4_task4();
        break;  
    case 5:
        les4_task5();
        break; 
    case 6:
        les4_task6();
        break; 
    default:
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.
void les4_task1()
{
    int [] array = new int[]{0, 1, 1, 1, 0, 0, 0, 1};

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.
void les4_task2()
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

//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].
void les4_task3()
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

// Найти сумму чисел одномерного массива стоящих на нечетной позиции.
void les4_task4()
{
    //Создание объекта для генерации чисел
    Random rnd = new Random();
    int [] array = new int[100];
    int sum = 0;


    //заполнение массива случайными трехзначными числами и суммирование значений стоящих на нечетной позиции
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
        if (i % 2 != 0) sum += array[i];
    }
    Console.WriteLine($"Сумма значений стоящих на нечетных позициях: {sum}");
}

//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void les4_task5()
{
    //Создание объекта для генерации чисел
    Random rnd = new Random();
    int [] array = new int[100];

    //заполнение массива случайными трехзначными числами
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }

    // вывод произведений пар чисел
     for (int i = 0; i < array.Length/2; i++)
    {
        Console.WriteLine($"Сумма произведений {i+1}-ой пары чисел ({array[i]} и {array[array.Length - (i + 1)]}): {array[i] * array[array.Length - (i + 1)]}");
    }
}

//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
void les4_task6()
{
    Console.WriteLine("Введите вещественные числа через пробел");
    // создаем переменную массива строк и в нее добавляем массив строк разделенных запятой
    string[] stringArray = Console.ReadLine().Split(' ');
    double [] array = new double[stringArray.Length];
    double min = 0;
    double max = 0;

    //заполняем массив ввещественных чисел со строкового массива 
    for (int i = 0; i < stringArray.Length; i++)
    {
        array[i] = double.Parse(stringArray[i].Trim());
    }

    min = array[0];
    max = array[0];

    // ищем минимальное и максимальное число в массиве
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }

    Console.WriteLine($"Разность между максимальным и минимальным элементом равно {max - min}");
}

// Seminar 8
Console.Clear();
Console.WriteLine("Выберите вариант задачи:\n\n" 
+ " 1 - Найти произведение двух матриц.\n" 
+ " 2 - В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.\n"
+ " 3 - Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.\n"
+ " 4 - Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника.\n");

int userVar = int.Parse(Console.ReadLine());

switch (userVar)
{
    case 1:
        les8_task1();
        break;
    case 2:
        les8_task2();
        break;
    case 3:
        les8_task3();
        break;
    case 4:
        les8_task4();
        break;
    default: 
        Console.WriteLine("Введеное число не соответсвует возможным вариантам");
        break;
}

//Найти произведение двух матриц.
void les8_task1()
{
    Console.WriteLine("Введите размерность m матрицы K:");
    int m1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите размерность n матрицы K:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите размерность m матрицы L:");
    int m2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите размерность n матрицы L:");
    int n2 = int.Parse(Console.ReadLine());
    bool flag = false;
    int [,] K = new int[n1, m1];
    int [,] L = new int[n2, m2];
    int [,] resultArray = new int[n2, m2];
    Random rnd = new Random();


    //проверка возможности умножения матриц в соответсвии с математическими правилами (m -столбцы, n - строки)
    if (m1 != 0 & n1 != 0 & m2 != 0 & n2 != 0)
    {
        if (m1 == n2)
        {
            flag = true;
        }
        else
        {
            Console.WriteLine ("Размерность m матрицы K должна быть равна размерности n матрицы L");
        }
    }

    else
    {
        Console.WriteLine ("Размерность матрицы не может быть равна нулю!");
    }

    //заполнение и вывод матрицы

    if (flag) 
    {
        Console.WriteLine ("Матрица K:");
        for (int i = 0; i < K.GetLength(0); i++)
        {
            for (int j = 0; j < K.GetLength(1); j++)
            {

                K[i, j] = rnd.Next(1, 10);
                Console.Write($"{K[i, j].ToString("0#")} | ");
            }

            Console.Write("\n");
        }

        Console.WriteLine ("Матрица L:");
        for (int i = 0; i < L.GetLength(0); i++)
        {
            for (int j = 0; j < L.GetLength(1); j++)
            {

                L[i, j] = rnd.Next(1, 9);
                Console.Write($"{L[i, j].ToString("0#")} | ");
            }

            Console.Write("\n");
        }

    //умножение матрицы
        for (int i = 0; i < L.GetLength(0); i++)
        {
            for (int j = 0; j < K.GetLength(1); j++)
            {
                for (int jj = 0; jj < K.GetLength(0); jj++)
                {
                    resultArray[i, j] += L[jj, j] * K[i, jj];
                }
            }
            
        }

    }

    // вывод результата произведения матриц
    Console.WriteLine ("Произведение матрицы K на L:");
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {

            K[i, j] = rnd.Next(1, 10);
            Console.Write($"{resultArray[i, j].ToString("00#")} | ");
        }

        Console.Write("\n");
    }


}

//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void les8_task2()
{
    Console.WriteLine("Введите размерность m:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите размерность n:");
    int n = int.Parse(Console.ReadLine());

    double [,] array = new double[n, m];
    double [ , ] minIndexElement = new double[1, 3];
    double [,] cutArray = new double[n - 1, m - 1];
    Random rnd = new Random();
    int ii = 0;
    int jj = 0;

    // заполнение массива случайными значениями и его вывод
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() + rnd.Next(1, 10);
            Console.Write($"{array[i, j].ToString("0#.#0")} | ");

            if (i == 0 & j == 0)
            {
                minIndexElement[0, 0] = array[i, j];
                minIndexElement[0, 1] = i;
                minIndexElement[0, 2] = j;
            }

            if (array[i, j] < minIndexElement[0, 0])
            {
                minIndexElement[0, 0] = array[i, j];
                minIndexElement[0, 1] = i;
                minIndexElement[0, 2] = j;
            }
        }

        Console.Write("\n");
    }
    
    Console.Write("\n");
    Console.WriteLine($"Минимальный элемент массива: {minIndexElement[0, 0].ToString("0#.#0")}. строка: {minIndexElement[0, 1] + 1}, столбец: {minIndexElement[0, 2] + 1} \n");

    // заполнение нового массива
    Console.WriteLine("Массив с удаленными элементами:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (minIndexElement[0, 1] != i & minIndexElement[0, 2] != j)
            {
                cutArray[ii, jj] = array [i, j];
                Console.Write($"{cutArray[ii, jj].ToString("0#.#0")} | ");
                jj += 1;
            }

        }
        
        if (minIndexElement[0, 1] != i) 
        {
            ii += 1; jj = 0; Console.Write("\n");
        }
    }
    
}

//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя 
//индексы соответствующего элемента.
void les8_task3()
{
     Console.WriteLine("Внимание! Количество элементов не должно превышать 99:");
    Console.WriteLine("Введите размерность m:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите размерность n:");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите размерность c:");
    int c = int.Parse(Console.ReadLine());
    int counter = 0;
    int [] arrayForCheck = new int [99];
    int [ , , ] array = new int[n, m, c];
    Random rnd = new Random();

    // проверка массива на количество элементов
    if (m * n * c > 99)
    {
        Console.WriteLine("Количество элементов в указанной размерности больше 99");
    }

    else
    {
        // заполнение массива и его вывод
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int jj = 0; jj < array.GetLength(2); jj++)
                {   
                    array[i, j, jj] = rnd.Next(1, 99);
                    Console.Write($"{array[i, j, jj].ToString("0#")} - индекс [{i}, {j}, {jj}] | ");
                }

                Console.Write("\n");
            }

        }
    }




}

//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void les8_task4()
{

}

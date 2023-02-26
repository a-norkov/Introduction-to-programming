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
    //string[] temp = Console.ReadLine().Split(',');   
    Console.WriteLine("Введите координаты вершин фигуры, пример (0.1, 0.2) (2,0) (2,2) (0,2), числа с плавающей точкой необходимо вводить через точку");
    string[] stringCoordinates = Console.ReadLine().Split(')');
    Console.WriteLine("Введеное k1:");
    double k = double.Parse(Console.ReadLine());
    
    double [,] arrayCoordinates = new double [stringCoordinates.Length - 1, 2];
    string[] tempCoordinates = new string[2];

    Console.WriteLine($"Координаты вершин фигуры с коэффициентом - {k}:");

    for (int i = 0; i < stringCoordinates.Length - 1; i++)
    {
        stringCoordinates[i] = stringCoordinates[i].Trim().TrimStart('(');
        tempCoordinates = stringCoordinates[i].Split(',');
        arrayCoordinates[i, 0] = double.Parse(tempCoordinates[0].Replace('.',','));
        arrayCoordinates[i, 1] = double.Parse(tempCoordinates[1].Replace('.',','));

        Console.Write ($"({arrayCoordinates[i, 0] * k}, {arrayCoordinates[i, 1] * k}) ");
        //Console.WriteLine(arrayCoordinates[i, 1] * k);
    }
}

// Написать программу копирования массива.
void les5_task3()
{


}

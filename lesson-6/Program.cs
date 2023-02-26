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

void les6_task1()
{

}

void les6_task2()
{

}

void les6_task3()
{

}

void les6_task4()
{

}

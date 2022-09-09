// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void AmountPositive(int size)
{
    int count = 0;
    for (int i = 1; i <= size; i++)
    {
        Console.WriteLine($"input number {i}");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n>0) count++;
    }
    Console.Write($"amount positive numbers is {count}");
}

Console.WriteLine("how many numbers do you want to enter?");
int size = Convert.ToInt32(Console.ReadLine());

AmountPositive(size);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

void IntersectionPoint()
{
    Console.WriteLine("enter two values for first line");
    double b1 = Convert.ToInt32(Console.ReadLine());
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter two values for second line");
    double b2 = Convert.ToInt32(Console.ReadLine());
    double k2 = Convert.ToInt32(Console.ReadLine());
    if (k1 == k2 && b1 == b2) Console.Write("these lines are coincide");
    else
    {
        if (k1 != k2)
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
            Console.Write("intersections point: x = " + x + " y = " + y);
        }
        else Console.Write("these lines are parallel");
    }
}

IntersectionPoint();
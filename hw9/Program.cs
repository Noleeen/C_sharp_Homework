// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// крайние не включены
/*
void Num(int m, int n)
{
    if (m > n+1)
    {
        Console.WriteLine($"{m-1}  ");
        Num(m-1, n);
    }
    if (m+1 < n)
    {
        Num(m, n - 1);
        Console.WriteLine($"{n-1}  ");
    }
}
Num(1, 7);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
/*
int Sum(int m, int n)
{
    if (m < n)
    {
        if (m < n) return Sum(m, n - 1) + n;
        else return n;
    }
    else
    {
        if (m > n) return Sum(m-1,n) + m;
        else return m;

    }
}
Console.WriteLine(Sum(6, 1));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if(m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;
}

Console.WriteLine("Enter  number: ");
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter  number: ");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.Write(Akkerman(m, n));
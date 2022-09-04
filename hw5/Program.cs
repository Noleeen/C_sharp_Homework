// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] NewArray(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
        myArray[i] = new Random().Next(100, 1000);
    return myArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
}

int AmountH(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int a = array[i] % 2;
        if(a == 0) count++;
    }
    return count;
}

Console.WriteLine("enter size array");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] myArray = NewArray(userSize);
ShowArray(myArray);
Console.WriteLine($"amount honest numbers is {AmountH(myArray)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] NewA(int size, int min, int max)
{
    int[] myArray = new int [size];
    for(int i = 0; i < size; i++)
    myArray[i] = new Random().Next(min, max + 1);
    return myArray;
}
void Show(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int SumOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
        sum += array[i];
    return sum;
}

Console.WriteLine("enter size array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter min value for array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter max value for array");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = NewA(size, min, max);
Show(myArray);
Console.WriteLine($"sum array's volume on odd positions is {SumOddPositions(myArray)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

double[] NewA(int size, int min, int max)
{
    double[] myArray = new double [size];
    for(int i = 0; i < size; i++)
    {
    double a = new Random().Next(min, max+1) + new Random().NextDouble();
    myArray[i] = a;
    }
    return myArray;
}
void Show(double[] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i] + "  ");
    Console.WriteLine();
}

double DiffMaxMin(double[] array)
{
    double diff;
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}

Console.WriteLine("enter size array");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter min value for array");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter max value for array");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = NewA(size, min, max);
Show(myArray);
Console.Write(DiffMaxMin(myArray));
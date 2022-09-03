// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
/*
int StepenB(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.WriteLine("введите число, затем нажмите ввод и введите степень, в которую нужно возвести это число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int st = Convert.ToInt32(Console.ReadLine());

Console.Write($"{userNumber} в степени {st} равно {StepenB(userNumber, st)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
void SumDigits(int z)
{
    int sum = 0;
    int count = z;
    for (int i = 0; count > 0; i++)
    {
        sum = count % 10 + sum;
        count = count / 10;
    }
    Console.Write($"sum digits your number is {sum}");
}
Console.WriteLine("enter number");
int userNumber = Convert.ToInt32(Console.ReadLine());
SumDigits(userNumber);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] UserArray(int size)
{
    int[] myArray = new int[size];
   
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("enter numbers for array and push enter");
        int a = Convert.ToInt32(Console.ReadLine());
        myArray[i] = a;
        
    }
    return myArray;
}

void ShowArray(int[] myNumbers)
{
    for (int i = 0; i < myNumbers.Length; i++)
        Console.Write(myNumbers[i] + "  ");

    Console.WriteLine();
}

Console.WriteLine("enter size array");
int userSize = Convert.ToInt32(Console.ReadLine());

ShowArray(UserArray(userSize));







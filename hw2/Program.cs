// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

/*
void SecondDigit(int num)
{
    int des = num % 100;
    int result = des / 10;
    Console.WriteLine(result); 
}

Console.WriteLine("enter threedigit number");
int userNumber = Convert.ToInt32(Console.ReadLine());
SecondDigit(userNumber);
*/

// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

/*
void ThirdDigit(int num)
{
    if(num > 99) 
    {
        while(num > 999)
        {
            num = num / 10;
        }
        int result = num % 10;     
        Console.WriteLine($"third digit is {result}");
        
    }
    else Console.WriteLine("no third digit");
}

Console.WriteLine("enter number");
int userNumber = Convert.ToInt32(Console.ReadLine());
ThirdDigit(userNumber);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void WeekDay (int num)
{
    if(num <= 5) Console.Write("this is working day");
    else Console.Write("this is weekend");
}

Console.WriteLine("enter number of the week day");
int day = Convert.ToInt32(Console.ReadLine());
WeekDay(day);
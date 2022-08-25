// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

void SecondDigit(int num)
{
    int des = num % 100;
    int result = des / 10;
    Console.WriteLine(result); 
}

Console.WriteLine("enter threedigit number");
int userNumber = Convert.ToInt32(Console.ReadLine());
SecondDigit(userNumber);


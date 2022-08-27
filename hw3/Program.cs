// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число (лучше любое)
// и проверяет, является ли оно палиндромом.

void Palindrom(int n, int number)
{
    int a1 = 0;
    int a2 = 0;
    int i = n;
    while(i > 0)
    {
        if(a1 == a2)
        {
            i--;
            a1 = number / (int)(Math.Pow(10,i));
            a2 = number % 10;
            number = number % (int)(Math.Pow(10,i));
            number = number / 10;
            i--;
            Console.WriteLine($"{a1}  {a2}  {i}  {number}");
        }
        else 
        {
            break;
        }
        
    }
   if(a1 == a2) Console.Write("your number is palindrome");
   else Console.Write("your number is not palindrome");
}

    Console.WriteLine("enter number");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("how many digits  in your number ");
    int amountDigits = Convert.ToInt32(Console.ReadLine());

    Palindrom(amountDigits, userNumber);
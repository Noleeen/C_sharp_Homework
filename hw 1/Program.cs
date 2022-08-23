// задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

/*Console.WriteLine("enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter seecond number");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number2;

if(number1 > number2) 
        max = number1;

Console.WriteLine("max = " + max);
*/

// -----------------------------------------------------------------------------------

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter seecond number");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter seecond number");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
    max = num2;

if(num3 > max)
    max = num3;

Console.WriteLine("max = " + max);

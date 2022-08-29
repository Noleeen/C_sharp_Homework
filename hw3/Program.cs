// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число (лучше любое)
// и проверяет, является ли оно палиндромом.
/*
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
    */

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Distance (double a1, double b1, double c1, double a2, double b2, double c2)
{
    double dist = Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2)+(c1-c2)*(c1-c2));
    Console.Write(dist);
}
Console.WriteLine("введите координаты первой точки:сначала воодите координату Х, затем 'Ввод', затем коорднату У, затем 'Ввод', затем координату Z");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты второй точки руководствуясь таким же принципом");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Distance (x1,y1,z1,x2,y2,z2);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    int i = 1;
    int result;
    while(i <= n)
    {
        result = i * i * i;
        Console.WriteLine($"{i} in a cube {result}");
        i++;
    }
}

Console.WriteLine("enter your number");
int userNumber = Convert.ToInt32(Console.ReadLine());
Cube(userNumber);
*/
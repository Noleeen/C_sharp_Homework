// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int[,] MatrixMN(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 1);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "   ");
        Console.WriteLine();
        Console.WriteLine();
    }
}

Console.WriteLine("enter amount rows for matrix");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter amount columns for matrix");
int columns = Convert.ToInt32(Console.ReadLine());

ShowMatrix(MatrixMN(rows, columns));

// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//  что такого элемента нет.

int[,] MatrixMN()
{
    int rows = new Random().Next(1, 8);
    int columns = new Random().Next(1, 8);
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(-9, 10);
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "   ");
        Console.WriteLine();
        Console.WriteLine();
    }
}

void ShowElement(int[,] matrix, int a, int b)
{
    if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
        Console.Write("this index is not found in array");
    else Console.Write(matrix[a-1, b-1]);
}

Console.WriteLine("enter number rows");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter number columns");
int b = Convert.ToInt32(Console.ReadLine());

int[,] m = MatrixMN();
ShowMatrix (m);
Console.WriteLine();
ShowElement (m, a, b);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

int[,] MatrixMN()
{
    int rows = new Random().Next(2, 8);
    int columns = new Random().Next(2, 8);
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "   ");
        Console.WriteLine();
        Console.WriteLine();
    }
}
void Average(int[,] m)
{
    for (int j = 0; j < m.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < m.GetLength(0); i++)
        {
            sum += m[i, j];
        }
        double a = Math.Round(Convert.ToDouble(sum) / m.GetLength(0),2);
        Console.Write(a + "   ");

    }
}


int[,] newM = MatrixMN();
ShowMatrix(newM);
Console.WriteLine("mean of columns:");
Average(newM);



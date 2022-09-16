// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] UserMatrix()
{
    Console.Write("input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min value for array ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max value for array ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(min, max + 1);


    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "   ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)/2; j++)
        {
            for (int m = j; m < matrix.GetLength(1) - 1 - j; m++)
                if (matrix[i, m] < matrix[i, m + 1])
                {
                    int temp = matrix[i, m];
                    matrix[i, m] = matrix[i, m + 1];
                    matrix[i, m + 1] = temp;
                }
            for (int n = matrix.GetLength(1) - 2 - j; n > j; n--)
                if (matrix[i, n] > matrix[i, n - 1])
                {
                    int temp = matrix[i, n];
                    matrix[i, n] = matrix[i, n - 1];
                    matrix[i, n - 1] = temp;
                }
        }
    }
}

int[,] myArray = UserMatrix();
ShowMatrix(myArray);
SortMatrix(myArray);
ShowMatrix(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/*

int[,] UserMatrix()
{
    Console.Write("input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input min value for array ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max value for array ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = new Random().Next(min, max + 1);


    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "   ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumRows(int[,] matrix)
{
    int sumRow0 = 0;
    int result = 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow0 += matrix[0,j];
    
    int temp = sumRow0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow += matrix[i,j];
        if(sumRow < temp)
        {
            temp = sumRow;
            result = i+1;
        }
    }
    Console.Write($"min sum elements in {result} row");
}

int[,] myArray = UserMatrix();
ShowMatrix(myArray);
SumRows(myArray);
*/
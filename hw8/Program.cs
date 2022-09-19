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


// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.


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

int[,] MultipliMatrix(int[,] m1, int[,] m2)
{
    if(m1.GetLength(1) == m2.GetLength(0))
    {
        int[,] mltpl = new int[m1.GetLength(0), m2.GetLength(1)];
        for (int i = 0; i < m1.GetLength(0); i++)
            for (int j = 0; j < m2.GetLength(1); j++)
                for (int n = 0; n < m1.GetLength(1); n++)
                    mltpl[i,j] = mltpl[i,j] + m1[i,n]*m2[n,j];
        return mltpl;
    }
    else 
    {
        Console.Write("These matrices cannot be multiply");
        int[,] m = new int [0,0];
        return m;
    }
}

Console.WriteLine("Enter first matrix:");
int[,] myArray = UserMatrix();
Console.WriteLine("Enter second matrix:");
int[,] myArray2 = UserMatrix();
ShowMatrix(myArray);
ShowMatrix(myArray2);
int[,] multMatr = MultipliMatrix(myArray, myArray2);
ShowMatrix(multMatr);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.


int[,,] UserMatrix3d()
{
    Console.Write("input number of rows ");
    int d1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("input number of columns ");
    int d2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("input number of 3d ");
    int d3 = Convert.ToInt32(Console.ReadLine());

    int[,,] matrix = new int[d1, d2, d3];
    for (int i = 0; i < d1; i++)
        for (int j = 0; j < d2; j++)
            for (int k = 0; k < d3; k++)
                matrix[i, j, k] = new Random().Next(10, 65);
    return matrix;
}

void DontRepeat(int[,,] m)
{
    int max = m[0, 0, 0];
    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            for (int k = 0; k < m.GetLength(2); k++)
                if (max < m[i, j, k])
                    max = m[i, j, k];
    int temp = m[0, 0, 0];
    int current = 1;
    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            for (int k = 0; k < m.GetLength(2); k++)
            {
                for (int x = 0; x < m.GetLength(0); x++)
                    for (int y = 0; y < m.GetLength(1); y++)
                        for (int z = 0; z < m.GetLength(2); z++)
                        {
                            if (x == i && y == j && z == k) continue;
                            if (m[x, y, z] == m[i, j, k])
                            {
                                m[x, y, z] = max + current;
                                current++;
                            }

                            // вот это второй вариант без поиска Макса, в нём есть нюнс, что 
                            // диапазон чисел должен быть на много больше элементов массива, 
                            // иначе будет долго подбирать 
                            // случайные неповторяющиеся числа...
                            
                            // if (x == i && y == j && z == k) continue;
                            // if (m[x, y, z] == m[i, j, k])
                            // {
                            //     int end = 1;
                            //     while( end == 1)
                            //     {
                            //         m[x, y, z] = new Random().Next(10,65);
                            //         for (int q = x; q >= 0; q--)
                            //             for (int w = y; w >= 0; w--)
                            //                 for (int e = z; e >= 0; e--)
                            //                 {
                            //                     if (x == q && y == w && z == e) continue;
                            //                     if (m[x, y, z] == m[q, w, z])
                            //                         end = 1;
                            //                     else end = 0;
                            //                 }
                            //     }
                            // }
                            
                        }
            }


}

void ShowMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
                Console.Write($"{matrix[i, k, j]} ({i},{k},{j})  ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

int[,,] my3dArray = UserMatrix3d();
ShowMatrix(my3dArray);

DontRepeat(my3dArray);

ShowMatrix(my3dArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] UserMatrix()
{
    Console.Write("input number of rows ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[size, size];

    int p = 0;
    int current = 1;
    for (int n = size; n > size / 2; n--)
    {
        int i = p;
        for (int j = p; j < n; j++)
        {
            if(matrix[i, j] != 0) break;
            matrix[i, j] = current;
            current++;
            if (j == n - 1)
            {
                for (i = p + 1; i < n; i++)
                {
                    if(matrix[i, j] != 0) break;
                    matrix[i, j] = current;
                    current++;
                    if (i == n - 1)
                    {
                        for (j = n - 2; j >= p; j--)
                        {
                            if(matrix[i, j] != 0) break;
                            matrix[i, j] = current;
                            current++;
                            if (j == p)
                            {
                                for (i = n - 2; i > 0 + p; i--)
                                {
                                    matrix[i, j] = current;
                                    current++;
                                }
                            }
                        }
                    }
                    Console.WriteLine("вот ещё работает");
                }Console.WriteLine("вот тут стопорится((");
            }
        }
        p++;

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
    }
    Console.WriteLine();
}

int[,] myArray = UserMatrix();
ShowMatrix(myArray);


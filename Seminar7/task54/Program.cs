// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void MinMaxSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = matrix[i,0];
            for (int k = 1; k < matrix.GetLength(1)-j; k++)
            {
                
                if (matrix[i,k]<max)
                {
                    matrix[i,k-1] = matrix[i,k];
                    matrix[i,k] = max;
                }
                else 
                    max = matrix[i,k];
            }
        }

    }
}


int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");

var Mymatrix = GenerateMatrix(rows, cols);
PrintMatrix(Mymatrix);
MinMaxSort(Mymatrix);
System.Console.WriteLine();
PrintMatrix(Mymatrix);
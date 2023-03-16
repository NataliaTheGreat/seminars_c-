//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int MaxElementsRow(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sums[i] += matrix[i, j];
        }
    }


    int max = sums[0];
    int rowindex = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (sums[i] < max)
        {
            max = sums[i];
            rowindex = i;
        }
    }
    return rowindex + 1; // lets be user friendly\\

}

    int rows = ReadInt("Введите количество строк матрицы: ");
    int cols = ReadInt("Введите количество столбцов матрицы: ");
    var Mymatrix = GenerateMatrix(rows, cols);
    PrintMatrix(Mymatrix);
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MaxElementsRow(Mymatrix)}");


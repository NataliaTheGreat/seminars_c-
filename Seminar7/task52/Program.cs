//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            matrix[i, j] = rand.Next(0, 21);
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

void AverageColumnsElements(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double tmp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            tmp += matrix[i, j];
        }
        tmp = Math.Round(tmp / matrix.GetLength(0), 2);
        average[j] = tmp;
    }
    
        Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", average)}");
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");


var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
AverageColumnsElements(myMatrix);

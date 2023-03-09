// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1)


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}


void SearchElement(int rowi, int rowj, int[,] matrix)
{
    if (rowi < matrix.GetLength(0)
        && rowj < matrix.GetLength(1)
        && rowi > 0
        && rowi > 0)
    {
        Console.WriteLine($"Элемент массива с  индексом [{rowi},{rowj}]  = {matrix[rowi, rowj]}");

    }
    else
        Console.WriteLine("Такой позиции в массиве нет");
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
        System.Console.WriteLine();
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
int rowi = ReadInt("Введите индекс элемента i: ");
int colj = ReadInt("Введите индекс элемента j: ");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
SearchElement(rowi, colj, myMatrix);

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int leftRange, int rightRange)
{
int[] array = new int[size];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange + 1); // 100, 999 + 1
}
return array;
}


int  ChetnyeChisla(int[] array)
{
int result = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i]%2==0) result++;
}
return result;

}


void PrintArray(int[] array)
{
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] myArray = GenerateArray(10, 100, 998);
PrintArray(myArray);
System.Console.WriteLine($"Количество четных чисел в массиве {ChetnyeChisla(myArray)}");

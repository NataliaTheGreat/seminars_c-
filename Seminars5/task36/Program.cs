//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] GenerateArray(int size, int leftRange, int rightRange)
{
int[] array = new int[size];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange + 1); // 
}
return array;
}


int  SumNechyotPos(int[] array) //функция подсчета суммы чисел на нечетных позициях
{
int result = 0;
for (int i = 1; i < array.Length; i=i+2)
{
result = result + array[i];
}
return result;
}


void PrintArray(int[] array)
{
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] myArray = GenerateArray(10, -100, 100);
PrintArray(myArray);
System.Console.WriteLine($"Сумма чисел на нечетных позициях равна {SumNechyotPos(myArray)}");

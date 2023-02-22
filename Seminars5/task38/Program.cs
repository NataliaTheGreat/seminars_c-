//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


double[] GenerateArray(int size, int leftRange, int rightRange)// генерируем массив случайных чисел
{
double[] array = new double [size];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange + 1); // 
}
return array;
}

double  MaxElement(double[] array) //функция нахождения max лемента
{
double max = 0;
for (int i =0; i < array.Length; ++i)
{
if (array[i]>max)  
{
    max=array[i];
}
}
return max;
}

double  MinElement(double[] array) //функция нахождения m min элемента
{
double min = 0;
for (int i =0; i < array.Length; ++i)
{
if (array[i]<min)  
{
    min=array[i];
}
}
return min;
}



void PrintArray(double[] array)
{
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


double[] myArray = GenerateArray(10, -100, 100);
PrintArray(myArray);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами {MaxElement(myArray)-MinElement(myArray)}");



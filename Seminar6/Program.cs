﻿//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//Считать число с консоли
int Prompt (string message)
{
    System.Console.Write(message); //вывести сообщение
    string value = Console.ReadLine();//считывает с консоли строку
    int result =Convert.ToInt32(value); //преобразует строку в целое число
    return result; //возвращает результат
}

//Ввести массив
 int[] InputArray (int length)
{   
    
    int[]array = new int [length];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Prompt ($"Введите {i+1}-й элемент ");
    }
    return array;
}

//Вывести массив
void PrintArray (int[] array)
{
    for (int i=0; i < array.Length;i++)
    {
        Console.WriteLine($"a[{i}]={array[i]}");
    }

}

//Функция подсчета положительных чисел в массиве
int CountPositiveNumbers(int[] array)
{
    int count =0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int lenght = Prompt ("Введите поличество элементов массива ");
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количество элементов >0 - {CountPositiveNumbers (array)}");


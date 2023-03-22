//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

System.Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int SumFromMtoN(int m, int n)
{
    if (m == n) return n;
    else return m + SumFromMtoN(m + 1, n);
}

if (m < n)
    Console.WriteLine($"Сумма элементов от {m} до {n} равна {SumFromMtoN(m, n)}");
else
    Console.WriteLine($"Сумма элементов от {n} до {m} равна {SumFromMtoN(n, m)}");

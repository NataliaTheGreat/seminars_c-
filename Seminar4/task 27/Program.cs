// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetNumber(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int GetSumm(int N)
{
int result = 0;

while (N%10 > 0)
{
result = result + N%10; 
N=N/10;
}
result = result + N/10;
return result;
}

int N = GetNumber("Введите число N: ");
int res = GetSumm(N);
System.Console.Write($"Сумма цифр числа = {res}");
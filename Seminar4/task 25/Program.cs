//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int GetNumber(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int GetStepen(int a, int b)
{
int result = 1;

for (int i = 1; i <= b; i++)
{
result *= a; // result = result X i;
}

return result;
}

int a = GetNumber("Введите число А: ");
int b = GetNumber("Введите число B: ");
int res = GetStepen(a, b);
System.Console.Write($"Число a, возведенное в степень b = {res}");
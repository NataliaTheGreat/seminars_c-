//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

System.Console.WriteLine ("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a<b)
{
  if (b==a*a)
  {
   System.Console.WriteLine ("да"); 
  }
  else
  {
    System.Console.WriteLine ("нет"); 
  }
}
else
{
    if (a==b*b)
  {
   System.Console.WriteLine ("да"); 
  }
  else
  {
    System.Console.WriteLine ("нет"); 
  }
}









//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
System.Console.WriteLine ("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<100) 
{
  System.Console.WriteLine ("Это двухзначное число. Перезапустите программу");  
}
else
  if (number>999) 
  {
   System.Console.WriteLine ("Это не трезначное число. Перезапустите программу");  
  }
  else
  {
  int number2 = number/10;
  //System.Console.WriteLine (number2);
  System.Console.Write("Вторая цифра числа ");
  System.Console.WriteLine (number2%10);
  }

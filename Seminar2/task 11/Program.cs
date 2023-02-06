//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

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
  int number2 = number/100;
  int number3 = number%10;
  System.Console.WriteLine ("Удалили вторую цифру и получили"); 
  System.Console.Write (number2);
  System.Console.Write (number3);
  }



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
   number = (number/100)*10 + number%10;
   System.Console.WriteLine ($"Удалили вторую цифру и получили: {number}"); 
   //System.Console.WriteLine ($"Удалили вторую цифру и получили: {number/100}{number%10}"); 
  }



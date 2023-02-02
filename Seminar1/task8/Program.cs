System.Console.WriteLine ("Введите число > 0");
int number = Convert.ToInt32(Console.ReadLine());
int b = number% 2; //остаток от деления
if(number<0)
{
   System.Console.WriteLine ("Вы ввели отрицательное число");
   System.Console.WriteLine ("Введите число > 0");
}
System.Console.Write("Вcе четные числа от 1 до ");  
System.Console.WriteLine(number);   
for(int i =1; i < number; i++)
{
  if(i % 2 == 0)
   {
   System.Console.Write(i);
   System.Console.Write(' ');
   }
  
}


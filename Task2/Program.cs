System.Console.WriteLine ("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
   System.Console.Write("Max=");
   System.Console.WriteLine (numberA);
   System.Console.Write("Min=");
   System.Console.WriteLine (numberB);
}
else 
{
   System.Console.Write("Max=");
   System.Console.WriteLine (numberB);
   System.Console.Write("Min=");
   System.Console.WriteLine (numberA);
}
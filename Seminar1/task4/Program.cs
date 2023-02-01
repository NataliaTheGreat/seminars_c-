System.Console.WriteLine ("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberB>numberA)
{
  if (numberB>numberC)
  {
   System.Console.Write("Max=");
   System.Console.WriteLine(numberB);
  }
  else
  {
   System.Console.Write("Max=");
   System.Console.WriteLine(numberC);
  }
}
else
{
  if (numberA>numberC)
  {
    System.Console.Write("Max=");
    System.Console.WriteLine(numberA);   
  }
  else
  {
    System.Console.Write("Max=");
    System.Console.WriteLine(numberC);   
  }
}
   

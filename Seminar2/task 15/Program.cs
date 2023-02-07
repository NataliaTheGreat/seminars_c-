//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

//System.Console.WriteLine ("Введите число от 1 до 7");
//int number = Convert.ToInt32(Console.ReadLine());

Random rand = new Random ();
int number = rand.Next (1,7);
System.Console.WriteLine ($"Случайный день недели: {number} ");
if (number == 1) System.Console.WriteLine ("Понедельник");
if (number == 2) System.Console.WriteLine ("Вторник");
if (number == 3) System.Console.WriteLine ("Среда");
if (number == 4) System.Console.WriteLine ("Четверг");
if (number == 5) System.Console.WriteLine ("Пятница");
if (number == 6) System.Console.WriteLine ("Суббота");
if (number == 7) System.Console.WriteLine ("Воскресенье");
if (number <6)
{
System.Console.WriteLine ("Будний день");   
}
else
{
System.Console.WriteLine ("Выходной день");   
}

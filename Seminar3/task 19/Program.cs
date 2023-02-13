//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

int NewNumber(int number)
{
return  number/10;
}

int Remainder(int number)
{
return  number%10;
}

System.Console.WriteLine ("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int fifth   =  Remainder(number);
int number2 =  NewNumber (number);
int fourth  =  Remainder(number2);
int number3 =  NewNumber(number2);
int third   =  Remainder(number3);
int number4 =  NewNumber(number3);
int second  =  Remainder(number4);
int number5 =  NewNumber(number4);
int first   =  Remainder(number5);

//System.Console.WriteLine (fifth);
//System.Console.WriteLine (fourth);
//System.Console.WriteLine (third);
//System.Console.WriteLine (second);
//System.Console.WriteLine (first);
 
if (first==fifth && second==fourth)
  System.Console.WriteLine ("Является палиндромом");
else
  System.Console.WriteLine ("Не является палиндромом");
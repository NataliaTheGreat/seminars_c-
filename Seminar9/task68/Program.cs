
int Akk(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akk(n - 1, 1);
    else
      return Akk(n - 1, Akk(n, m - 1));
}

Console.Write("Задайте число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($" A({m},{n})= {(Akk(m,n))}");


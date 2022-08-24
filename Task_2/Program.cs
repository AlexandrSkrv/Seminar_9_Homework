// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

void replacement(int numM, int numN)
{
  int varRep = m;
  if (m > n)
  {
    m = n;
    n = varRep;
  }
}
replacement(m, n);

void sumNum(int numM, int numN, int sum)
{
  if (m == n)
  {
    Console.Write($"{m}"); return;
  }

  if (numM > numN)
  {
    Console.Write($"{sum} "); return;

  }
  sum = sum + numN;
  sumNum(numM, numN - 1, sum);
}

sumNum(m, n, 0);

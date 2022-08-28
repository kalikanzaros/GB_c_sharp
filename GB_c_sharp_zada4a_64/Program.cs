/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
Console.Write($"Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.\n");
Console.Write($"Введите значение M:");
int m = ParseIntInput();
Console.Write($"Введите значение N:");
int n = ParseIntInput();

Console.Write($"M = {m};N = {n}.->\"");
Increment(m, n);
static int ParseIntInput()
{
  while (true)
  {
    if (int.TryParse(Console.ReadLine(), out int result) == true && result > 0)
    {
      return result;
    }
    else
    {
      Console.WriteLine($"Не INT, введите ещё раз: ");
    }
  }
}
void Increment(int m, int n )
{
  if (m > n)
  {
    Console.WriteLine($"{m}");
  }
  if (m < n)
  {
    Console.Write($"{m},");
    Increment(m+1, n);
  }
  if (m == n)
  {
    Console.Write($"{n}\"");
  }
}